using System;
using System.Windows;
using System.IO;


namespace MSDS_TDS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_elaboraMSDS_Click(object sender, RoutedEventArgs e)
        {

           
            int i;
            int ind = 0;
            int d;
            string[] a;
            string b;
            string p;
            string c;                       
            string lin;
            string app;
            string[] lines2;
            DateTime latest;
            string pathdesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fname = Convert.ToString(txt_nfile.Text);
            string ddest = Convert.ToString(txt_destinazione.Text);
            string pdest = pathdesktop + @"\" + ddest;
            string pfile = pathdesktop + @"\" + fname + ".txt";

            if (fname != "" && ddest != "")
            {
                if (Directory.Exists(pdest))
                {
                    MessageBox.Show("la cartella esiste già - cambiare nome");

                }

                else
                {
                    if (File.Exists(pfile))
                    {
                        DirectoryInfo di = Directory.CreateDirectory(pdest);

                        StreamReader sr = new StreamReader(pfile);

                        try
                        {
                            lines2 = File.ReadAllLines(pfile);

                            foreach (string li in lines2)
                            {

                                // MessageBox.Show(li);
                                lin = li.Trim();

                                if (lin == "")
                                {


                                }

                                else
                                {
                                    app = "";
                                    app = li.Substring(0, 6);
                                    app = app.Trim();


                                    if (app != null)
                                    {
                                        string[] files = Directory.GetFiles(@"\\PATH)
                                        if (files != null)
                                        {
                                           

                                            for (i = 0; i < files.Length; i++)
                                            {
                               

                                                c = Path.GetFileName(files[i]);
                                                a = c.Split('-');
                                                b = a[0].Trim();
                                                //MessageBox.Show(app + "   " + a[0]);

                                                if (app == b)
                                                {
                                                    if (files.Length == 1)
                                                    {
                                                        p = Path.Combine(pdest, Path.GetFileName(files[0]));
                                                        File.Copy(files[0], p, true);
                                                    }

                                                    else if (files.Length > 1)
                                                    {
                                                        latest = File.GetLastWriteTime(files[0]);
                                                        ind = 0;

                                                        for (d = 0; d < files.Length; d++)
                                                        {
                                                            if (latest < File.GetLastWriteTime(files[d]))
                                                            {
                                                                latest = File.GetLastWriteTime(files[d]);
                                                                ind = d;
                                                            }
                                                        }


                                                        p = Path.Combine(pdest, Path.GetFileName(files[ind]));


                                                        //   MessageBox.Show(p);
                                                        File.Copy(files[ind], p, true);

                                                    }

                                                }
                                            }
                                        }
                                    }
                                }

                            }



                            if (Directory.GetFiles(pdest) == null)
                            {
                                MessageBox.Show("Nessuna Scheda di sicurezza Trovata");
                            }
                            else
                            {
                                MessageBox.Show("schede di sicurezza salvate");
                            }



                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show("non ho trovato il file " + ex);
                        }
                    }

                    else
                    {
                        MessageBox.Show("non trovo il file");

                    }
                }
            }

        
        }

        private void btn_elaboraTDS_Click(object sender, RoutedEventArgs e)
        {



            int i;
            int ind = 0;
            int d;
            string[] a;
            string b;
            string p;
            string c;
            string lin;
            string app;
            string[] lines2;
            DateTime latest;
            string pathdesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fname = Convert.ToString(txt_nfile.Text);
            string ddest = Convert.ToString(txt_destinazione.Text);
            string pdest = pathdesktop + @"\" + ddest;
            string pfile = pathdesktop + @"\" + fname + ".txt";

            if (fname != "" && ddest != "")
            {
                if (Directory.Exists(pdest))
                {
                    MessageBox.Show("la cartella esiste già - cambiare nome");

                }

                else
                {
                    if (File.Exists(pfile))
                    {
                        DirectoryInfo di = Directory.CreateDirectory(pdest);

                        StreamReader sr = new StreamReader(pfile);

                        try
                        {
                            lines2 = File.ReadAllLines(pfile);

                            foreach (string li in lines2)
                            {

                                // MessageBox.Show(li);
                                lin = li.Trim();

                                if (lin == "")
                                {


                                }

                                else
                                {
                                    app = "";
                                    app = li.Substring(0, 6);
                                    app = app.Trim();


                                    if (app != null)
                                    {
                                        string[] files = Directory.GetFiles(@"\\PATH)
                                        if (files != null)
                                        {


                                            for (i = 0; i < files.Length; i++)
                                            {


                                                c = Path.GetFileName(files[i]);
                                                a = c.Split('-');
                                                b = a[0].Trim();
                                                //MessageBox.Show(app + "   " + a[0]);

                                                if (app == b)
                                                {
                                                    if (files.Length == 1)
                                                    {
                                                        p = Path.Combine(pdest, Path.GetFileName(files[0]));
                                                        File.Copy(files[0], p, true);
                                                    }

                                                    else if (files.Length > 1)
                                                    {
                                                        latest = File.GetLastWriteTime(files[0]);
                                                        ind = 0;

                                                        for (d = 0; d < files.Length; d++)
                                                        {
                                                            if (latest < File.GetLastWriteTime(files[d]))
                                                            {
                                                                latest = File.GetLastWriteTime(files[d]);
                                                                ind = d;
                                                            }
                                                        }


                                                        p = Path.Combine(pdest, Path.GetFileName(files[ind]));


                                                        //   MessageBox.Show(p);
                                                        File.Copy(files[ind], p, true);

                                                    }

                                                }
                                            }
                                        }
                                    }
                                }

                            }



                            if (Directory.GetFiles(pdest) == null)
                            {
                                MessageBox.Show("Nessuna Scheda tecnica Trovata");
                            }
                            else
                            {
                                MessageBox.Show("schede tecniche salvate");
                            }



                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show("non ho trovato il file " + ex);
                        }
                    }

                    else
                    {
                        MessageBox.Show("non trovo il file");

                    }
                }
            }

        }
    }
}
