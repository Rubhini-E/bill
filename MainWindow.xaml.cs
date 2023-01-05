using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Schema;

namespace bill
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
    
        private int P1()
        {
            txtname0.Text = "toor dal";
            txtprice0.Text = "100";
            txtdis0.Text = "10";
             int discount = 10;
            //txtqua0.Text = Convert.ToInt32(quantity);
          int quantity = Convert.ToInt32(txtqua0.Text.ToString());
           // int pp = 100 * quantity;
            //int total = pp - 10;

           int total = 100 * quantity - 10;
            txttot0.Text = total.ToString();
            return 0;
         
        }
        private int P2()
        {
            txtname0.Text = "moongu dal";
            txtprice0.Text = "60";
            txtdis0.Text = "10";
            int discount = 10;
            //txtqua0.Text = Convert.ToInt32(quantity);
            int quantity = Convert.ToInt32(txtqua0.Text.ToString());
            // int pp = 100 * quantity;
            //int total = pp - 10;

            int total = 60 * quantity - 10;
            txttot0.Text = total.ToString();
            return 0;

        }
        private int P3()
        {
            txtname0.Text = "kitkat";
            txtprice0.Text = "20";
            txtdis0.Text = "0";
            int discount = 0;
            //txtqua0.Text = Convert.ToInt32(quantity);
            int quantity = Convert.ToInt32(txtqua0.Text.ToString());
            // int pp = 100 * quantity;
            //int total = pp - 10;

            int total = 20 * quantity - 0;
            txttot0.Text = total.ToString();
            return 0;



        }

        private int P4()
        {
            txtname0.Text = "50-50";
            txtprice0.Text = "10";
            txtdis0.Text = "1";
            int discount = 1;
            //txtqua0.Text = Convert.ToInt32(quantity);
            int quantity = Convert.ToInt32(txtqua0.Text.ToString());
            // int pp = 100 * quantity;
            //int total = pp - 10;

            int total = 10 * quantity - 1;
            txttot0.Text = total.ToString();
            return 0;


        }

        private int P5()
           {
            txtname0.Text = "aloe bar";
            txtprice0.Text = "70";
            txtdis0.Text = "5";
            int discount = 5;
            //txtqua0.Text = Convert.ToInt32(quantity);
            int quantity = Convert.ToInt32(txtqua0.Text.ToString());
            // int pp = 100 * quantity;
            //int total = pp - 10;

            int total = 70 * quantity - 5;
            txttot0.Text = total.ToString();
            return 0;


        }
        private int P6()
        {
            txtname0.Text = "noodles";
            txtprice0.Text = "120";
            txtdis0.Text = "20";
            int discount = 20;
            //txtqua0.Text = Convert.ToInt32(quantity);
            int quantity = Convert.ToInt32(txtqua0.Text.ToString());
            // int pp = 100 * quantity;
            //int total = pp - 10;

            int total = 120 * quantity - 20;
            txttot0.Text = total.ToString();
            return 0;

        }
        private int P7()
        {
            txtname0.Text = "BRU coffee";
            txtprice0.Text = "90";
            txtdis0.Text = "5";
            int discount = 5;
            int quantity = Convert.ToInt32(txtqua0.Text.ToString());
            int total = 90 * quantity - 5;
            txttot0.Text = total.ToString();
            return 0;
        }
        private int q1()
        {
            txtname1.Text = "toor dal";
            txtprice1.Text = "100";
            txtdis1.Text = "10";
            int discount = 10;
            //txtqua0.Text = Convert.ToInt32(quantity);
            int quantity = Convert.ToInt32(txtqua1.Text.ToString());
            // int pp = 100 * quantity;
            //int total = pp - 10;

            int total = 100 * quantity - 10;
            txttot1.Text = total.ToString();
            return 0;

        }
        private int q2()
        {
            txtname1.Text = "moongu dal";
            txtprice1.Text = "60";
            txtdis1.Text = "10";
            int discount = 10;
            //txtqua0.Text = Convert.ToInt32(quantity);
            int quantity = Convert.ToInt32(txtqua1.Text.ToString());
            // int pp = 100 * quantity;
            //int total = pp - 10;

            int total = 60 * quantity - 10;
            txttot1.Text = total.ToString();
            return 0;

        }
        private int q3()
        {
            txtname1.Text = "kitkat";
            txtprice1.Text = "20";
            txtdis1.Text = "0";
            int discount = 0;
            //txtqua0.Text = Convert.ToInt32(quantity);
            int quantity = Convert.ToInt32(txtqua1.Text.ToString());
            // int pp = 100 * quantity;
            //int total = pp - 10;

            int total = 20 * quantity - 0;
            txttot1.Text = total.ToString();
            return 0;



        }

        private int q4()
        {
            txtname1.Text = "50-50";
            txtprice1.Text = "10";
            txtdis1.Text = "1";
            int discount = 1;
            //txtqua0.Text = Convert.ToInt32(quantity);
            int quantity = Convert.ToInt32(txtqua1.Text.ToString());
            // int pp = 100 * quantity;
            //int total = pp - 10;

            int total = 10 * quantity - 1;
            txttot1.Text = total.ToString();
            return 0;


        }

        private int q5()
        {
            txtname1.Text = "aloe bar";
            txtprice1.Text = "70";
            txtdis1.Text = "5";
            int discount = 5;
            //txtqua0.Text = Convert.ToInt32(quantity);
            int quantity = Convert.ToInt32(txtqua1.Text.ToString());
            // int pp = 100 * quantity;
            //int total = pp - 10;

            int total = 70 * quantity - 5;
            txttot1.Text = total.ToString();
            return 0;


        }
        private int q6()
        {
            txtname1.Text = "noodles";
            txtprice1.Text = "120";
            txtdis1.Text = "20";
            int discount = 20;
            //txtqua0.Text = Convert.ToInt32(quantity);
            int quantity = Convert.ToInt32(txtqua1.Text.ToString());
            // int pp = 100 * quantity;
            //int total = pp - 10;

            int total = 120 * quantity - 20;
            txttot1.Text = total.ToString();
            return 0;

        }
        private int q7()
        {
            txtname1.Text = "BRU coffee";
            txtprice1.Text = "90";
            txtdis1.Text = "5";
            int discount = 5;
            int quantity = Convert.ToInt32(txtqua1.Text.ToString());
            int total = 90 * quantity - 5;
            txttot1.Text = total.ToString();
            return 0;
        }

        private int r1()
        {
            txtname2.Text = "toor dal";
            txtprice2.Text = "100";
            txtdis2.Text = "10";
            int discount = 10;
            //txtqua0.Text = Convert.ToInt32(quantity);
            int quantity = Convert.ToInt32(txtqua2.Text.ToString());
            // int pp = 100 * quantity;
            //int total = pp - 10;

            int total = 100 * quantity - 10;
            txttot2.Text = total.ToString();
            return 0;

        }
        private int r2()
        {
            txtname2.Text = "moongu dal";
            txtprice2.Text = "60";
            txtdis2.Text = "10";
            int discount = 10;
            //txtqua0.Text = Convert.ToInt32(quantity);
            int quantity = Convert.ToInt32(txtqua2.Text.ToString());
            // int pp = 100 * quantity;
            //int total = pp - 10;

            int total = 60 * quantity - 10;
            txttot2.Text = total.ToString();
            return 0;

        }
        private int r3()
        {
            txtname2.Text = "kitkat";
            txtprice2.Text = "20";
            txtdis2.Text = "0";
            int discount = 0;
            //txtqua0.Text = Convert.ToInt32(quantity);
            int quantity = Convert.ToInt32(txtqua2.Text.ToString());
            // int pp = 100 * quantity;
            //int total = pp - 10;

            int total = 20 * quantity - 0;
            txttot2.Text = total.ToString();
            return 0;



        }

        private int r4()
        {
            txtname2.Text = "50-50";
            txtprice2.Text = "10";
            txtdis2.Text = "1";
            int discount = 1;
            //txtqua0.Text = Convert.ToInt32(quantity);
            int quantity = Convert.ToInt32(txtqua2.Text.ToString());
            // int pp = 100 * quantity;
            //int total = pp - 10;

            int total = 10 * quantity - 1;
            txttot2.Text = total.ToString();
            return 0;


        }

        private int r5()
        {
            txtname2.Text = "aloe bar";
            txtprice2.Text = "70";
            txtdis2.Text = "5";
            int discount = 5;
            //txtqua0.Text = Convert.ToInt32(quantity);
            int quantity = Convert.ToInt32(txtqua2.Text.ToString());
            // int pp = 100 * quantity;
            //int total = pp - 10;

            int total = 70 * quantity - 5;
            txttot2.Text = total.ToString();
            return 0;


        }
        private int r6()
        {
            txtname2.Text = "noodles";
            txtprice2.Text = "120";
            txtdis2.Text = "20";
            int discount = 20;
            //txtqua0.Text = Convert.ToInt32(quantity);
            int quantity = Convert.ToInt32(txtqua2.Text.ToString());
            // int pp = 100 * quantity;
            //int total = pp - 10;

            int total = 120 * quantity - 20;
            txttot2.Text = total.ToString();
            return 0;

        }
        private int r7()
        {
            txtname2.Text = "BRU coffee";
            txtprice2.Text = "90";
            txtdis2.Text = "5";
            int discount = 5;
            int quantity = Convert.ToInt32(txtqua2.Text.ToString());
            int total = 90 * quantity - 5;
            txttot2.Text = total.ToString();
            return 0;
        }

        private int s1()
        {
            txtname3.Text = "toor dal";
            txtprice3.Text = "100";
            txtdis3.Text = "10";
            int discount = 10;
            //txtqua0.Text = Convert.ToInt32(quantity);
            int quantity = Convert.ToInt32(txtqua3.Text.ToString());
            // int pp = 100 * quantity;
            //int total = pp - 10;

            int total = 100 * quantity - 10;
            txttot3.Text = total.ToString();
            return 0;

        }
        private int s2()
        {
            txtname3.Text = "moongu dal";
            txtprice3.Text = "60";
            txtdis3.Text = "10";
            int discount = 10;
            //txtqua0.Text = Convert.ToInt32(quantity);
            int quantity = Convert.ToInt32(txtqua3.Text.ToString());
            // int pp = 100 * quantity;
            //int total = pp - 10;

            int total = 60 * quantity - 10;
            txttot3.Text = total.ToString();
            return 0;

        }
        private int s3()
        {
            txtname3.Text = "kitkat";
            txtprice3.Text = "20";
            txtdis3.Text = "0";
            int discount = 0;
            //txtqua0.Text = Convert.ToInt32(quantity);
            int quantity = Convert.ToInt32(txtqua3.Text.ToString());
            // int pp = 100 * quantity;
            //int total = pp - 10;

            int total = 20 * quantity - 0;
            txttot3.Text = total.ToString();
            return 0;



        }

        private int s4()
        {
            txtname3.Text = "50-50";
            txtprice3.Text = "10";
            txtdis3.Text = "1";
            int discount = 1;
            //txtqua0.Text = Convert.ToInt32(quantity);
            int quantity = Convert.ToInt32(txtqua3.Text.ToString());
            // int pp = 100 * quantity;
            //int total = pp - 10;

            int total = 10 * quantity - 1;
            txttot3.Text = total.ToString();
            return 0;


        }

        private int s5()
        {
            txtname3.Text = "aloe bar";
            txtprice3.Text = "70";
            txtdis3.Text = "5";
            int discount = 5;
            //txtqua0.Text = Convert.ToInt32(quantity);
            int quantity = Convert.ToInt32(txtqua3.Text.ToString());
            // int pp = 100 * quantity;
            //int total = pp - 10;

            int total = 70 * quantity - 5;
            txttot3.Text = total.ToString();
            return 0;


        }
        private int s6()
        {
            txtname3.Text = "noodles";
            txtprice3.Text = "120";
            txtdis3.Text = "20";
            int discount = 20;
            //txtqua0.Text = Convert.ToInt32(quantity);
            int quantity = Convert.ToInt32(txtqua3.Text.ToString());
            // int pp = 100 * quantity;
            //int total = pp - 10;

            int total = 120 * quantity - 20;
            txttot3.Text = total.ToString();
            return 0;

        }
        private int s7()
        {
            txtname3.Text = "BRU coffee";
            txtprice3.Text = "90";
            txtdis3.Text = "5";
            int discount = 5;
            int quantity = Convert.ToInt32(txtqua3.Text.ToString());
            int total = 90 * quantity - 5;
            txttot3.Text = total.ToString();
            return 0;
        }
        private int t1()
        {
            txtname4.Text = "toor dal";
            txtprice4.Text = "100";
            txtdis4.Text = "10";
            int discount = 10;
            //txtqua0.Text = Convert.ToInt32(quantity);
            int quantity = Convert.ToInt32(txtqua4.Text.ToString());
            // int pp = 100 * quantity;
            //int total = pp - 10;

            int total = 100 * quantity - 10;
            txttot4.Text = total.ToString();
            return 0;

        }
        private int t2()
        {
            txtname4.Text = "moongu dal";
            txtprice4.Text = "60";
            txtdis4.Text = "10";
            int discount = 10;
            //txtqua0.Text = Convert.ToInt32(quantity);
            int quantity = Convert.ToInt32(txtqua4.Text.ToString());
            // int pp = 100 * quantity;
            //int total = pp - 10;

            int total = 60 * quantity - 10;
            txttot4.Text = total.ToString();
            return 0;

        }
        private int t3()
        {
            txtname4.Text = "kitkat";
            txtprice4.Text = "20";
            txtdis4.Text = "0";
            int discount = 0;
            //txtqua0.Text = Convert.ToInt32(quantity);
            int quantity = Convert.ToInt32(txtqua4.Text.ToString());
            // int pp = 100 * quantity;
            //int total = pp - 10;

            int total = 20 * quantity - 0;
            txttot4.Text = total.ToString();
            return 0;



        }

        private int t4()
        {
            txtname4.Text = "50-50";
            txtprice4.Text = "10";
            txtdis4.Text = "1";
            int discount = 1;
            //txtqua0.Text = Convert.ToInt32(quantity);
            int quantity = Convert.ToInt32(txtqua4.Text.ToString());
            // int pp = 100 * quantity;
            //int total = pp - 10;

            int total = 10 * quantity - 1;
            txttot4.Text = total.ToString();
            return 0;


        }

        private int t5()
        {
            txtname4.Text = "aloe bar";
            txtprice4.Text = "70";
            txtdis4.Text = "5";
            int discount = 5;
            //txtqua0.Text = Convert.ToInt32(quantity);
            int quantity = Convert.ToInt32(txtqua4.Text.ToString());
            // int pp = 100 * quantity;
            //int total = pp - 10;

            int total = 70 * quantity - 5;
            txttot4.Text = total.ToString();
            return 0;


        }
        private int t6()
        {
            txtname4.Text = "noodles";
            txtprice4.Text = "120";
            txtdis4.Text = "20";
            int discount = 20;
            //txtqua0.Text = Convert.ToInt32(quantity);
            int quantity = Convert.ToInt32(txtqua4.Text.ToString());
            // int pp = 100 * quantity;
            //int total = pp - 10;

            int total = 120 * quantity - 20;
            txttot4.Text = total.ToString();
            return 0;

        }
        private int t7()
        {
            txtname4.Text = "BRU coffee";
            txtprice4.Text = "90";
            txtdis4.Text = "5";
            int discount = 5;
            int quantity = Convert.ToInt32(txtqua4.Text.ToString());
            int total = 90 * quantity - 5;
            txttot4.Text = total.ToString();
            return 0;
        }

        private int u1()
        {
            txtname5.Text = "toor dal";
            txtprice5.Text = "100";
            txtdis5.Text = "10";
            int discount = 10;
            //txtqua0.Text = Convert.ToInt32(quantity);
            int quantity = Convert.ToInt32(txtqua5.Text.ToString());
            // int pp = 100 * quantity;
            //int total = pp - 10;

            int total = 100 * quantity - 10;
            txttot5.Text = total.ToString();
            return 0;

        }
        private int u2()
        {
            txtname5.Text = "moongu dal";
            txtprice5.Text = "60";
            txtdis5.Text = "10";
            int discount = 10;
            //txtqua0.Text = Convert.ToInt32(quantity);
            int quantity = Convert.ToInt32(txtqua5.Text.ToString());
            // int pp = 100 * quantity;
            //int total = pp - 10;

            int total = 60 * quantity - 10;
            txttot5.Text = total.ToString();
            return 0;

        }
        private int u3()
        {
            txtname5.Text = "kitkat";
            txtprice5.Text = "20";
            txtdis5.Text = "0";
            int discount = 0;
            //txtqua0.Text = Convert.ToInt32(quantity);
            int quantity = Convert.ToInt32(txtqua5.Text.ToString());
            // int pp = 100 * quantity;
            //int total = pp - 10;

            int total = 20 * quantity - 0;
            txttot5.Text = total.ToString();
            return 0;



        }

        private int u4()
        {
            txtname5.Text = "50-50";
            txtprice5.Text = "10";
            txtdis5.Text = "1";
            int discount = 1;
            //txtqua0.Text = Convert.ToInt32(quantity);
            int quantity = Convert.ToInt32(txtqua5.Text.ToString());
            // int pp = 100 * quantity;
            //int total = pp - 10;

            int total = 10 * quantity - 1;
            txttot5.Text = total.ToString();
            return 0;


        }

        private int u5()
        {
            txtname5.Text = "aloe bar";
            txtprice5.Text = "70";
            txtdis5.Text = "5";
            int discount = 5;
            //txtqua0.Text = Convert.ToInt32(quantity);
            int quantity = Convert.ToInt32(txtqua5.Text.ToString());
            // int pp = 100 * quantity;
            //int total = pp - 10;

            int total = 70 * quantity - 5;
            txttot5.Text = total.ToString();
            return 0;


        }
        private int u6()
        {
            txtname5.Text = "noodles";
            txtprice5.Text = "120";
            txtdis5.Text = "20";
            int discount = 20;
            //txtqua0.Text = Convert.ToInt32(quantity);
            int quantity = Convert.ToInt32(txtqua5.Text.ToString());
            // int pp = 100 * quantity;
            //int total = pp - 10;

            int total = 120 * quantity - 20;
            txttot5.Text = total.ToString();
            return 0;

        }
        private int u7()
        {
            txtname5.Text = "BRU coffee";
            txtprice5.Text = "90";
            txtdis5.Text = "5";
            int discount = 5;
            int quantity = Convert.ToInt32(txtqua5.Text.ToString());
            int total = 90 * quantity - 5;
            txttot5.Text = total.ToString();
            return 0;
        }
        private int v1()
        {
            txtname6.Text = "toor dal";
            txtprice6.Text = "100";
            txtdis6.Text = "10";
            int discount = 10;
            //txtqua0.Text = Convert.ToInt32(quantity);
            int quantity = Convert.ToInt32(txtqua6.Text.ToString());
            // int pp = 100 * quantity;
            //int total = pp - 10;

            int total = 100 * quantity - 10;
            txttot6.Text = total.ToString();
            return 0;

        }
        private int v2()
        {
            txtname6.Text = "moongu dal";
            txtprice6.Text = "60";
            txtdis6.Text = "10";
            int discount = 10;
            //txtqua0.Text = Convert.ToInt32(quantity);
            int quantity = Convert.ToInt32(txtqua6.Text.ToString());
            // int pp = 100 * quantity;
            //int total = pp - 10;

            int total = 60 * quantity - 10;
            txttot6.Text = total.ToString();
            return 0;

        }
        private int v3()
        {
            txtname6.Text = "kitkat";
            txtprice6.Text = "20";
            txtdis6.Text = "0";
            int discount = 0;
            //txtqua0.Text = Convert.ToInt32(quantity);
            int quantity = Convert.ToInt32(txtqua6.Text.ToString());
            // int pp = 100 * quantity;
            //int total = pp - 10;

            int total = 20 * quantity - 0;
            txttot6.Text = total.ToString();
            return 0;



        }

        private int v4()
        {
            txtname6.Text = "50-50";
            txtprice6.Text = "10";
            txtdis6.Text = "1";
            int discount = 1;
            //txtqua0.Text = Convert.ToInt32(quantity);
            int quantity = Convert.ToInt32(txtqua6.Text.ToString());
            // int pp = 100 * quantity;
            //int total = pp - 10;

            int total = 10 * quantity - 1;
            txttot6.Text = total.ToString();
            return 0;


        }

        private int v5()
        {
            txtname6.Text = "aloe bar";
            txtprice6.Text = "70";
            txtdis6.Text = "5";
            int discount = 5;
            //txtqua0.Text = Convert.ToInt32(quantity);
            int quantity = Convert.ToInt32(txtqua6.Text.ToString());
            // int pp = 100 * quantity;
            //int total = pp - 10;

            int total = 70 * quantity - 5;
            txttot6.Text = total.ToString();
            return 0;


        }
        private int v6()
        {
            txtname6.Text = "noodles";
            txtprice6.Text = "120";
            txtdis6.Text = "20";
            int discount = 20;
            //txtqua0.Text = Convert.ToInt32(quantity);
            int quantity = Convert.ToInt32(txtqua6.Text.ToString());
            // int pp = 100 * quantity;
            //int total = pp - 10;

            int total = 120 * quantity - 20;
            txttot6.Text = total.ToString();
            return 0;

        }
        private int v7()
        {
            txtname6.Text = "BRU coffee";
            txtprice6.Text = "90";
            txtdis6.Text = "5";
            int discount = 5;
            int quantity = Convert.ToInt32(txtqua1.Text.ToString());
            int total = 90 * quantity - 5;
            txttot6.Text = total.ToString();
            return 0;
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int a1 = Convert.ToInt32(txttot0.Text);
            int a2 = Convert.ToInt32(txttot1.Text);
            int a3 = Convert.ToInt32(txttot2.Text);
            int a4 = Convert.ToInt32(txttot3.Text);
            int a5 = Convert.ToInt32(txttot4.Text);
            int a6 = Convert.ToInt32(txttot5.Text);
            int a7 = Convert.ToInt32(txttot6.Text);

            int total = a1 + a2 + a3 + a4 + a5 + a6 + a7;


            //    int t1 = Convert.ToInt32(txtprice0.Text + txtprice1.Text + txtprice2.Text + txtprice3.Text);
            //    int t2 = Convert.ToInt32(txtprice4.Text + txtprice5.Text + txtprice6.Text);
            //    int total = t1 + t2;
            lbltotal.Content = total.ToString();

            int gst = 5 % total;
            lblgst.Content = gst.ToString();
            int sgst= 2 % total;
            lblsgst.Content = sgst.ToString();

            lblgtot.Content = total - gst - sgst;
        }

       
        
        private void txtcode0_MouseEnter(object sender, MouseEventArgs e)
        {
            if (txtcode0.Text == "1")
            {
                P1();
            }
            else if (txtcode0.Text == "2")
            {
                P2();

            }
            else if (txtcode0.Text == "3")
            {
                P3();

            }
            else if (txtcode0.Text == "4")
            {
                P4();

            }
            else if (txtcode0.Text == "5")
            {
                P5();

            }
            else if (txtcode0.Text == "6")
            {
                P6();

            }
            else if (txtcode0.Text == "7")
            {
                P7();

            }
        }

        private void txtcode1_MouseEnter(object sender, MouseEventArgs e)
        {
            if (txtcode1.Text == "1")
            {
                q1();
            }
            else if (txtcode1.Text == "2")
            {
                q2();

            }
            else if (txtcode1.Text == "3")
            {
                q3();

            }
            else if (txtcode1.Text == "4")
            {
                q4();

            }
            else if (txtcode1.Text == "5")
            {
                q5();

            }
            else if (txtcode1.Text == "6")
            {
                q6();

            }
            else if (txtcode1.Text == "7")
            {
                q7();

            }
        }

        private void txtcode2_MouseEnter(object sender, MouseEventArgs e)
        {
            if (txtcode2.Text == "1")
            {
                r1();
            }
            else if (txtcode2.Text == "2")
            {
                r2();

            }
            else if (txtcode2.Text == "3")
            {
                r3();

            }
            else if (txtcode2.Text == "4")
            {
                r4();

            }
            else if (txtcode2.Text == "5")
            {
                r5();

            }
            else if (txtcode2.Text == "6")
            {
                r6();

            }
            else if (txtcode2.Text == "7")
            {
                r7();

            }
        }

        private void txtcode3_MouseEnter(object sender, MouseEventArgs e)
        {
            if (txtcode3.Text == "1")
            {
                s1();
            }
            else if (txtcode3.Text == "2")
            {
                s2();

            }
            else if (txtcode3.Text == "3")
            {
                s3();

            }
            else if (txtcode3.Text == "4")
            {
                s4();

            }
            else if (txtcode3.Text == "5")
            {
                s5();

            }
            else if (txtcode3.Text == "6")
            {
                s6();

            }
            else if (txtcode3.Text == "7")
            {
                s7();

            }
        }

        private void txtcode4_MouseEnter(object sender, MouseEventArgs e)
        {
            if (txtcode4.Text == "1")
            {
                t1();
            }
            else if (txtcode4.Text == "2")
            {
                t2();

            }
            else if (txtcode4.Text == "3")
            {
                t3();

            }
            else if (txtcode4.Text == "4")
            {
                t4();

            }
            else if (txtcode4.Text == "5")
            {
                t5();

            }
            else if (txtcode4.Text == "6")
            {
                t6();

            }
            else if (txtcode4.Text == "7")
            {
                t7();

            }
        }

        private void txtcode5_MouseEnter(object sender, MouseEventArgs e)
        {
            if (txtcode5.Text == "1")
            {
                u1();
            }
            else if (txtcode5.Text == "2")
            {
                u2();

            }
            else if (txtcode5.Text == "3")
            {
                u3();

            }
            else if (txtcode5.Text == "4")
            {
                u4();

            }
            else if (txtcode5.Text == "5")
            {
                u5();

            }
            else if (txtcode5.Text == "6")
            {
                u6();

            }
            else if (txtcode5.Text == "7")
            {
                u7();

            }
        }

        private void txtcode6_MouseEnter(object sender, MouseEventArgs e)
        {
            if (txtcode6.Text == "1")
            {
                v1();
            }
            else if (txtcode6.Text == "2")
            {
                v2();

            }
            else if (txtcode6.Text == "3")
            {
                v3();

            }
            else if (txtcode6.Text == "4")
            {
                v4();

            }
            else if (txtcode6.Text == "5")
            {
                v5();

            }
            else if (txtcode6.Text == "6")
            {
                v6();

            }
            else if (txtcode6.Text == "7")
            {
                v7();

            }
        }

        private void Label_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void txttot5_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
