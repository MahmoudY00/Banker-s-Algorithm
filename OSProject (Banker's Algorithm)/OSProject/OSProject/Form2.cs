using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OSProject
{
    public partial class Form2 : Form
    {
        int[] Total_Resources;
        int[] Avaliable_Resources;
        int[,] Current_Allocation;
        int[,] Max_Need;
        int[,] Remain_Need;

        public int requested, avalaible;

        public string pro;

        public List<string> list = new List<string>();

        bool x;

        public string s;

        int enter;

        public int count;

        public string avaliable_s;
        public static List<string> steps = new List<string>();

        public Form2()
        {
            InitializeComponent();
            TotalResources();
            AvaliableResources();
            CurrectAllocation();
            MaxNeed();
            ReminingNeed();
            comboboxcreation();


        }

        public void TotalResources()
        {
            dataGridView1.ColumnCount = Form1.no_of_resources;
            dataGridView1.RowCount = 1;
            for (int i = 0; i < Form1.no_of_resources; i++)
            {
                dataGridView1.Columns[i].Name = "R" + (i + 1);
            }

        }
        public void AvaliableResources()
        {
            dataGridView2.ColumnCount = Form1.no_of_resources;
            dataGridView2.RowCount = 1;
            for (int i = 0; i < Form1.no_of_resources; i++)
            {
                dataGridView2.Columns[i].Name = "R" + (i + 1);
            }

        }
        public void CurrectAllocation()
        {
            dataGridView3.ColumnCount = Form1.no_of_resources;
            dataGridView3.RowCount = Form1.no_of_process;
            for (int i = 0; i < Form1.no_of_resources; i++)
            {
                dataGridView3.Columns[i].Name = "R" + (i + 1);
            }
            for (int i = 0; i < Form1.no_of_process; i++)
            {
                dataGridView3.Rows[i].HeaderCell.Value = "P" + (i + 1);
            }

        }
        public void MaxNeed()
        {
            dataGridView4.ColumnCount = Form1.no_of_resources;
            dataGridView4.RowCount = Form1.no_of_process;
            for (int i = 0; i < Form1.no_of_resources; i++)
            {
                dataGridView4.Columns[i].Name = "R" + (i + 1);
            }
            for (int i = 0; i < Form1.no_of_process; i++)
            {
                dataGridView4.Rows[i].HeaderCell.Value = "P" + (i + 1);
            }

        }
        public void ReminingNeed()
        {
            dataGridView5.ColumnCount = Form1.no_of_resources;
            dataGridView5.RowCount = Form1.no_of_process;
            for (int i = 0; i < Form1.no_of_resources; i++)
            {
                dataGridView5.Columns[i].Name = "R" + (i + 1);
            }
            for (int i = 0; i < Form1.no_of_process; i++)
            {
                dataGridView5.Rows[i].HeaderCell.Value = "P" + (i + 1);
            }

        }


        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (string.IsNullOrEmpty(cell.Value?.ToString()))
                {
                    MessageBox.Show("Please enter a value.");
                    cell.Value = "";
                    dataGridView1.CurrentCell = cell;
                }
                else
                {
                    int value;
                    if (!int.TryParse(cell.Value.ToString(), out value) || value < 0)
                    {
                        MessageBox.Show("Please enter a positive integer value.");
                        cell.Value = "";
                        dataGridView1.CurrentCell = cell;
                    }
                }
            }
        }
        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                DataGridViewCell cell = dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (string.IsNullOrEmpty(cell.Value?.ToString()))
                {
                    MessageBox.Show("Please enter a value.");
                    cell.Value = "";
                    dataGridView2.CurrentCell = cell;
                }
                else
                {
                    int value;
                    if (!int.TryParse(cell.Value.ToString(), out value) || value < 0)
                    {
                        MessageBox.Show("Please enter a positive integer value.");
                        cell.Value = "";
                        dataGridView2.CurrentCell = cell;
                    }
                }
            }




        }
        private void dataGridView3_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                DataGridViewCell cell = dataGridView3.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (string.IsNullOrEmpty(cell.Value?.ToString()))
                {
                    MessageBox.Show("Please enter a value.");
                    cell.Value = "";
                    dataGridView3.CurrentCell = cell;
                }
                else
                {
                    int value;
                    if (!int.TryParse(cell.Value.ToString(), out value) || value < 0)
                    {
                        MessageBox.Show("Please enter a positive integer value.");
                        cell.Value = "";
                        dataGridView3.CurrentCell = cell;
                    }
                }
            }
        }
        private void dataGridView4_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                DataGridViewCell cell = dataGridView4.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (string.IsNullOrEmpty(cell.Value?.ToString()))
                {
                    MessageBox.Show("Please enter a value.");
                    cell.Value = "";
                    dataGridView4.CurrentCell = cell;
                }
                else
                {
                    int value;
                    if (!int.TryParse(cell.Value.ToString(), out value) || value < 0)
                    {
                        MessageBox.Show("Please enter a positive integer value.");
                        cell.Value = "";
                        dataGridView4.CurrentCell = cell;
                    }
                }
            }



        }

        public void enterdata()
        {
            Total_Resources = new int[dataGridView1.Columns.Count];
            Avaliable_Resources = new int[dataGridView2.Columns.Count];
            Current_Allocation = new int[dataGridView3.Rows.Count, dataGridView3.Columns.Count];
            Max_Need = new int[dataGridView4.Rows.Count, dataGridView4.Columns.Count];
            Remain_Need = new int[dataGridView5.Rows.Count, dataGridView5.Columns.Count];

            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < Form1.no_of_resources; j++)
                {
                    int value;
                    if (int.TryParse(dataGridView1.Rows[i].Cells[j].Value.ToString(), out value))
                    {
                        Total_Resources[j] = value;

                    }

                    if (int.TryParse(dataGridView2.Rows[i].Cells[j].Value.ToString(), out value))
                    {
                        Avaliable_Resources[j] = value;

                    }
                }
            }
            for (int i = 0; i < Form1.no_of_process; i++)
            {
                for (int j = 0; j < Form1.no_of_resources; j++)
                {
                    int value;
                    if (int.TryParse(dataGridView3.Rows[i].Cells[j].Value.ToString(), out value))
                    {
                        Current_Allocation[i, j] = value;

                    }

                    if (int.TryParse(dataGridView4.Rows[i].Cells[j].Value.ToString(), out value))
                    {
                        Max_Need[i, j] = value;

                    }

                    if (Max_Need[i, j] < Current_Allocation[i, j])
                    {
                        MessageBox.Show("Maximum Need Should Be Greater Than Or Equal To The Current Allocation");
                        Environment.Exit(0);
                    }



                }

            }

        }

        public void Remain()
        {

            for (int i = 0; i < Form1.no_of_process; i++)
            {
                for (int j = 0; j < Form1.no_of_resources; j++)
                {



                    Remain_Need[i, j] = Max_Need[i, j] - Current_Allocation[i, j];
                    dataGridView5.Rows[i].Cells[j].Value = Remain_Need[i, j];



                }

            }



        }

        private void Enter2_Click(object sender, EventArgs e)
        {
            enterdata();
            Remain();
            dataGridView1.ReadOnly = true;
            dataGridView2.ReadOnly = true;
            dataGridView3.ReadOnly = true;
            dataGridView4.ReadOnly = true;
            dataGridView5.ReadOnly = true;

            Request();

            logic();

           


        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Section Is For Requesting Resource For A Process If Needed");
        }

        private void comboboxcreation()
        {


            for (int i = 0; i < Form1.no_of_process; i++)
            {
                List<string> process = new List<string>();
                process.Add("P" + (i + 1).ToString());
                comboBox1.Items.AddRange(process.ToArray());
            }
            for (int i = 0; i < Form1.no_of_resources; i++)
            {
                List<string> resource = new List<string>();
                resource.Add("R" + (i + 1).ToString());
                comboBox2.Items.AddRange(resource.ToArray());
            }


        }

        private void Request()
        {

            if (!string.IsNullOrEmpty(resreqtxt.Text) && (comboBox1.SelectedIndex != -1) && (comboBox2.SelectedIndex != -1))
            {
                if ((int.TryParse(resreqtxt.Text, out int p)))
                {
                    if (p > 0)
                    {
                        requested = int.Parse(resreqtxt.Text);
                        string x = comboBox2.SelectedItem.ToString();

                        for (int i = 0; i < Avaliable_Resources.Length; i++)
                        {
                            if (dataGridView2.Columns[i].HeaderText == x)
                            {
                                avalaible = int.Parse(dataGridView2.Rows[0].Cells[i].Value.ToString());
                            }
                        }

                        if (avalaible >= requested)
                        {
                            for (int i = 0; i < Avaliable_Resources.Length; i++)
                            {
                                if (dataGridView2.Columns[i].HeaderText == x)
                                {
                                    Avaliable_Resources[i] -= requested;
                                    dataGridView2.Rows[0].Cells[i].Value = Avaliable_Resources[i];
                                }
                            }

                            string y = comboBox1.SelectedItem.ToString();

                            for (int i = 0; i < dataGridView3.Rows.Count; i++)
                            {
                                for (int j = 0; j < dataGridView3.Columns.Count; j++)
                                {
                                    if ((y == dataGridView3.Rows[i].HeaderCell.Value.ToString()) && (x == dataGridView3.Columns[j].HeaderText))
                                    {
                                        Current_Allocation[i, j] += requested;
                                        dataGridView3.Rows[i].Cells[j].Value = Current_Allocation[i, j];
                                    }
                                }
                            }
                        }
                        else
                        {
                            dataGridView5.Hide();
                            MessageBox.Show("UNSAFE!!!, As The Requested Resources is Greater Than The Avaliable Resources");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Please Enter Postive Number Of Resources Requested Greater Than 0");

                    }


                }
                else
                {
                    MessageBox.Show("Please Enter An Integer Number Of Resources Requested");

                }

            }

        }
        
        public void logic()
        {
             Form3 form3 = new Form3();
            x = true;
            int y = 0;



            int[] checkarr = new int[Avaliable_Resources.Length];
            int[] test = new int[Avaliable_Resources.Length];

            while (x == true)
            {
                for (int i = 0; i < Avaliable_Resources.Length; i++)
                {
                    checkarr[i] = Avaliable_Resources[i];
                }


                for (int i = 0; i < dataGridView5.Rows.Count; i++)
                {
                    bool matchFound = false;
                    foreach (string x in list)
                    {
                        if (x == dataGridView5.Rows[i].HeaderCell.Value.ToString())
                        {
                            matchFound = true;
                            break;
                        }
                    }
                    if (matchFound)
                    {
                        continue;
                    }
                    for (int j = 0; j < dataGridView5.Columns.Count; j++)
                    {
                        if (Avaliable_Resources[j] >= Remain_Need[i, j])
                        {
                            y++;
                            s = dataGridView5.Rows[i].HeaderCell.Value.ToString();
                            test[j] = Current_Allocation[i, j];
                        }
                        if (y == dataGridView5.Columns.Count)
                        {
                            enter = 1;
                            list.Add(s);
                            y = 0;
                            for (int k = 0; k < Avaliable_Resources.Length; k++)
                            {
                                Avaliable_Resources[k] += test[k];
                            }
                            steps.Add(Environment.NewLine + "Available Resources are greater than or equal Remain Need" + Environment.NewLine + dataGridView5.Rows[i].HeaderCell.Value.ToString() + " is in Safe State" + Environment.NewLine + print_available() + Environment.NewLine);
                        }
                    }
                     if (enter != 1)

                      steps.Add(Environment.NewLine + " Available Resources are less than Remain Need" + Environment.NewLine + dataGridView5.Rows[i].HeaderCell.Value.ToString() + " wait for other processes " + Environment.NewLine + print_available() + Environment.NewLine);
                   
                    Array.Clear(test, 0, test.Length);
                    y = 0;
                     enter = 0;
                }


                    for (int m = 0; m < checkarr.Length; m++)
                    {
                        if (checkarr[m] == Avaliable_Resources[m])
                        {
                            count++;
                        }
                    }
                    if (count == Avaliable_Resources.Length)
                    {
                        x = false;
                    }
                    else
                    {
                        count = 0;
                    }
                }




                for (int i = 0; i < Avaliable_Resources.Length; i++)
                {
                    dataGridView2.Rows[0].Cells[i].Value = Avaliable_Resources[i];
                }
                if (list.Count == Form1.no_of_process)
                {
                    
                    MessageBox.Show("Safe");
                }
                else
                {
                    
                    MessageBox.Show("Unsafe");
                }

                foreach (string x in list)
                {
                    MessageBox.Show(x);
                }
            }

        private void Steps_Button_Click(object sender, EventArgs e)
        {
            
            Form3 form3 = new Form3();
            form3.Show();
        }

        public string print_available()
        {
            avaliable_s = "";
            for (int i = 0; i < Avaliable_Resources.Length; i++)

            {
                avaliable_s += (Avaliable_Resources[i].ToString() + "  ");
            }

            return ("Available Resources = " + avaliable_s);

        }




    }
}
 
