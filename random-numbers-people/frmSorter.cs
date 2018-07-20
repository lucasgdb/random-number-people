using System.Linq;

namespace random_numbers
{
    public partial class frmSorter : System.Windows.Forms.Form
    {
        public frmSorter()
        {
            InitializeComponent();
            lblBCurrent.Text = "Build atual: " + BCurrent;
            lblCBuild.Text = "Build atual: " + BCurrent;
            SelectPanel(pSorter);
        }

        int BCurrent = 3;
        string lastSorter = null;
        int amountPeople = 0;

        void SelectPanel(System.Windows.Forms.Panel panel)
        {
            System.Windows.Forms.Panel[] panels = { pSorter, pUpdate, pAbout };
            System.Windows.Forms.Button[] btns = { btnSorter, btnUpdate, btnAbout };
            for (int i = 0; i < panels.Length; i++)
                if (panels[i] == panel && !panel.Visible)
                {
                    panel.Visible = true; btns[i].BackColor = System.Drawing.Color.Orange;
                }
                else if (panels[i] != panel && panels[i].Visible == true)
                {
                    panels[i].Visible = false; btns[i].BackColor = System.Drawing.Color.OrangeRed;
                }
            panel.Select();
        }

        void AddPeople(string name)
        {
            if (name.Length == 0)
                System.Windows.Forms.MessageBox.Show("Digite o nome da pessoa!", "Erro", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            else lvNames.Items.Add(new System.Windows.Forms.ListViewItem(new string[] { name, (++amountPeople).ToString() }));
        }

        private void btnSorter_Click(object sender, System.EventArgs e)
        {
            SelectPanel(pSorter);
        }

        private void btnUpdate_Click(object sender, System.EventArgs e)
        {
            SelectPanel(pUpdate);
        }

        private void btnAbout_Click(object sender, System.EventArgs e)
        {
            SelectPanel(pAbout);
        }

        private void picGitHub_Click(object sender, System.EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/LucasNaja/random-number-people");
        }

        private void cbSelect_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (cbSelect.SelectedIndex == 0)
            {
                pNumber.Visible = true;
                pPeople.Visible = false;
            }
            else
            {
                pNumber.Visible = false;
                pPeople.Visible = true;
            }
            SelectPanel(pSorter);
        }

        private void frmSorter_Load(object sender, System.EventArgs e)
        {
            cbSelect.SelectedIndex = 0;
        }

        private void aNumbers_ValueChanged(object sender, System.EventArgs e)
        {
            if (nAmount.Value > 1 && !lblAmount.Text.Contains('s'))
                lblAmount.Text = lblAmount.Text + 's';
            else if (nAmount.Value == 1)
                lblAmount.Text = lblAmount.Text.Remove(lblAmount.Text.Length - 1);
        }

        private void pSorter_Click(object sender, System.EventArgs e)
        {
            SelectPanel(pSorter);
        }

        private void btnGenerate_Click(object sender, System.EventArgs e)
        {
            int qtd = (int)nAmount.Value, min = (int)aMinimum.Value, max = (int)aMaximum.Value + 1;

            if (max < min)
                System.Windows.Forms.MessageBox.Show("Não é possível gerar números do intervalo escolhido!", "Erro", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            else if (qtd > max - min)
                System.Windows.Forms.MessageBox.Show("Não é possível gerar a quantidade de números escolhido!", "Erro", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            else
            {
                lvGenNumbers.Clear();
                int[] n = new int[qtd];
                System.Random rnd = new System.Random();
                for (int i = 0; i < qtd; i++)
                {
                    int num = rnd.Next(min, max);
                    while (System.Array.IndexOf(n, num) != -1)
                        num = rnd.Next(min, max);
                    n[i] = num;
                }

                if (rbAscendent.Checked)
                    System.Array.Sort(n);
                else if (rbDescendent.Checked)
                {
                    System.Array.Sort(n); System.Array.Reverse(n);
                }

                for (int i = 0; i < qtd; i++)
                    lvGenNumbers.Items.Add(n[i].ToString());
            }
        }

        private void btnAddName_Click(object sender, System.EventArgs e)
        {
            pSorter.Select();
            AddPeople(txtName.Text.Trim());
            txtName.Clear();
            txtName.Select();
        }

        private void btnClearLast_Click(object sender, System.EventArgs e)
        {
            pSorter.Select();
            if (lvNames.Items.Count > 0)
            {
                amountPeople--;
                lvNames.Items[lvNames.Items.Count - 1].Remove();
            }
        }

        private void btnClear_Click(object sender, System.EventArgs e)
        {
            pSorter.Select();
            lvNames.Items.Clear();
            amountPeople = 0;
        }

        private void btnRandomName_Click(object sender, System.EventArgs e)
        {
            if (amountPeople > 1)
            {
                System.Random rnd = new System.Random();
                int random = rnd.Next(0, lvNames.Items.Count);
                lastSorter = lvNames.Items[random].SubItems[0].Text + " índice " + lvNames.Items[random].SubItems[1].Text;
                System.Windows.Forms.MessageBox.Show("Pessoa sorteada: " + lvNames.Items[random].SubItems[0].Text +
                    " índice " + lvNames.Items[random].SubItems[1].Text, "Sorteio", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            }
            else System.Windows.Forms.MessageBox.Show("Não há pessoas suficientes participando do sorteio!", "Erro", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            pSorter.Select();
        }

        private void txtName_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
                e.Handled = true;
        }

        private void txtName_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                AddPeople(txtName.Text.Trim());
                txtName.Clear();
                txtName.Select();
            }
        }

        private void btnLastResult_Click(object sender, System.EventArgs e)
        {
            if (lastSorter != null)
                System.Windows.Forms.MessageBox.Show("Último sorteio: " + lastSorter, "Sorteio", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            else System.Windows.Forms.MessageBox.Show("Nenhum sorteio foi realizado ainda!", "Sorteio", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            pSorter.Select();
        }

        private void btnImport_Click(object sender, System.EventArgs e)
        {
            pSorter.Select();
            System.Windows.Forms.OpenFileDialog ofd = new System.Windows.Forms.OpenFileDialog()
            {
                Filter = "Arquivos de texto(*.txt)|*.txt",
                Title = "Importar nomes",
                CheckFileExists = true,
                CheckPathExists = true
            };

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string[] names = System.IO.File.ReadAllLines(ofd.FileName);
                for (int i = 0; i < names.Length; i++)
                    AddPeople(names[i]);
            }
        }

        private void tsmiRemove_Click(object sender, System.EventArgs e)
        {
            if (lvNames.SelectedIndices.Count > 0)
                lvNames.Items.RemoveAt(lvNames.SelectedIndices[0]);
        }

        private void tsmiClearAll_Click(object sender, System.EventArgs e)
        {
            lvNames.Items.Clear();
        }

        private void pNumber_Click(object sender, System.EventArgs e)
        {
            pNumber.Select();
        }

        private void pPeople_Click(object sender, System.EventArgs e)
        {
            pPeople.Select();
        }

        private void btnUptoDate_Click(object sender, System.EventArgs e)
        {
            pUpdate.Select();
            btnUptoDate.Enabled = false;
            picGif.Visible = true;
            System.Net.WebClient wc = new System.Net.WebClient();

            if (btnUptoDate.Text == "Verificar atualizações")
            {
                lblStatus.Text = "Status: Conectando-se ao servidor...";
                wc.DownloadStringAsync(new System.Uri("https://drive.google.com/uc?authuser=0&id=1Wt3PRdCfeiKPoYqB3Lh3hg4rzEDpnTnc&export=download"));

                wc.DownloadStringCompleted += (s, ee) =>
                {
                    try
                    {
                        btnUptoDate.Enabled = true;
                        picGif.Visible = false;
                        if (System.Convert.ToInt16(ee.Result.Split('\n')[0]) > BCurrent)
                        {
                            lblStatus.Text = "Status: Há nova versão disponível para baixar!";
                            btnUptoDate.Text = "Baixar atualizações";
                            tip.SetToolTip(btnUptoDate, "Baixar atualização de programa");
                        }
                        else
                            lblStatus.Text = "Status: Não há nova versão disponível para baixar!";
                    }
                    catch
                    {
                        btnUptoDate.Enabled = true;
                        picGif.Visible = false;
                    }
                };
            }
            else
            {
                lblStatus.Text = "Status: Conectando-se ao servidor...";
                wc.DownloadStringAsync(new System.Uri("https://drive.google.com/uc?authuser=0&id=1Wt3PRdCfeiKPoYqB3Lh3hg4rzEDpnTnc&export=download"));

                wc.DownloadStringCompleted += (s, ee) =>
                {
                    picGif.Visible = false;
                    try
                    {
                        if (System.Convert.ToInt16(ee.Result.Split('\n')[0]) > BCurrent)
                        {
                            wc.DownloadFileAsync(new System.Uri(ee.Result.Split('\n')[1]), System.Windows.Forms.Application.StartupPath + "\\Sorteador de Números e Pessoas.rar");
                            wc.DownloadProgressChanged += (ss, eee) =>
                                lblStatus.Text = "Status: Baixando nova versão [" + eee.BytesReceived / 1024 + " de " + ee.Result.Split('\n')[2] + ']';

                            wc.DownloadFileCompleted += (ss, eee) =>
                            {
                                try
                                {
                                    picGif.Visible = false;
                                    lblStatus.Text = "Status: Nova versão baixada com sucesso!\nFeche e extraia o novo programa na pasta atual.";
                                    lblStatus.Cursor = System.Windows.Forms.Cursors.Hand;
                                    lblStatus.Click += (sss, eeee) => this.Close();
                                    tip.SetToolTip(lblStatus, "Clique aqui");
                                }
                                catch
                                {
                                    picGif.Visible = false;
                                }
                            };
                        }
                        else
                        {
                            lblStatus.Text = "Status: Não há nova versão disponível para baixar!";
                            btnUptoDate.Enabled = true;
                            tip.SetToolTip(btnUptoDate, "Verificar atualização de programa");
                            picGif.Visible = false;
                            btnUptoDate.Text = "Verificar atualizações";
                        }
                    }
                    catch
                    {
                        btnUptoDate.Enabled = true;
                        picGif.Visible = false;
                    }
                };
            }
        }

        private void pUpdate_Click(object sender, System.EventArgs e)
        {
            pUpdate.Select();
        }

        private void btnClear2_Click(object sender, System.EventArgs e)
        {
            pSorter.Select();
            lvGenNumbers.Items.Clear();
        }

        private void pAbout_Click(object sender, System.EventArgs e)
        {
            pAbout.Select();
        }

        private void tsmiClearAll2_Click(object sender, System.EventArgs e)
        {
            lvGenNumbers.Items.Clear();
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (lastSorter != null)
            {
                int i = 1;
                while (System.IO.File.Exists(System.Windows.Forms.Application.StartupPath + "\\Sorteio" + i + ".txt"))
                    i++;
                try
                {
                    System.IO.StreamWriter sw = new System.IO.StreamWriter(System.Windows.Forms.Application.StartupPath + "\\Sorteio" + i + ".txt");
                    sw.Write("Sorteio realizado em " + System.DateTime.Now + ", resultado: " + lastSorter);
                    sw.Close();
                    System.Windows.Forms.MessageBox.Show("Sorteio salvo com sucesso! Salvo em: " + System.Windows.Forms.Application.StartupPath + "\\Sorteio" + i + ".txt", "Sorteio", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show("Algum erro ocorreu! Por favor, contate o desenvolvedor em Sobre.", "Erro", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                }
            }
            else System.Windows.Forms.MessageBox.Show("Nenhum sorteio foi realizado ainda!", "Erro", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            pSorter.Select();
        }

        private void picGitHub_MouseEnter(object sender, System.EventArgs e)
        {
            picGitHub.Location = new System.Drawing.Point(picGitHub.Location.X - 1, picGitHub.Location.Y - 1);
            picGitHub.Size = new System.Drawing.Size(picGitHub.Size.Width + 2, picGitHub.Size.Height + 2);
        }

        private void picGitHub_MouseLeave(object sender, System.EventArgs e)
        {
            picGitHub.Location = new System.Drawing.Point(picGitHub.Location.X + 1, picGitHub.Location.Y + 1);
            picGitHub.Size = new System.Drawing.Size(picGitHub.Size.Width - 2, picGitHub.Size.Height - 2);
        }
    }
}
