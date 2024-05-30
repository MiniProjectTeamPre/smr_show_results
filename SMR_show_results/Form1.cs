using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace smr_show_results {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            PictureBox[] p = new PictureBox[36];
            p[0] = pictureBox1; p[4] = pictureBox5; p[8] = pictureBox9; p[12] = pictureBox13; p[16] = pictureBox17;
            p[1] = pictureBox2; p[5] = pictureBox6; p[9] = pictureBox10; p[13] = pictureBox14; p[17] = pictureBox18;
            p[2] = pictureBox3; p[6] = pictureBox7; p[10] = pictureBox11; p[14] = pictureBox15; p[18] = pictureBox19;
            p[3] = pictureBox4; p[7] = pictureBox8; p[11] = pictureBox12; p[15] = pictureBox16; p[19] = pictureBox20;
            p[20] = pictureBox21; p[21] = pictureBox22; p[22] = pictureBox23; p[23] = pictureBox24; p[24] = pictureBox25;
            p[25] = pictureBox26; p[26] = pictureBox27; p[27] = pictureBox28; p[28] = pictureBox29; p[29] = pictureBox30;
            p[30] = pictureBox31; p[31] = pictureBox32; p[32] = pictureBox33; p[33] = pictureBox34; p[34] = pictureBox35;
            p[35] = pictureBox36;
            string s1 = "";
            string s2 = "";
            try { s1 = File.ReadAllText("smr_show_results_tested_006.txt"); } catch { }
            try { s2 = File.ReadAllText("smr_show_results_tested_005.txt"); } catch { }
            if (s1 == "" && s2 == "") { MessageBox.Show("_อ่านไฟล์ที่ส่งมาจากโปรแกรม Main ไม่ได้"); return; }
            if(s1 != "") {
                string[] ss1 = File.ReadAllLines("smr_show_results_tested_006.txt");
                Image img = Properties.Resources.smr_pass;
                for(int i = 1; i <= 36; i++) {
                    switch (i) {
                        case 1: img = Properties.Resources.smr_non1; break;
                        case 2: img = Properties.Resources.smr_non2; break;
                        case 3: img = Properties.Resources.smr_non3; break;
                        case 4: img = Properties.Resources.smr_non4; break;
                        case 5: img = Properties.Resources.smr_non5; break;
                        case 6: img = Properties.Resources.smr_non6; break;
                        case 7: img = Properties.Resources.smr_non7; break;
                        case 8: img = Properties.Resources.smr_non8; break;
                        case 9: img = Properties.Resources.smr_non9; break;
                        case 10: img = Properties.Resources.smr_non10; break;
                        case 11: img = Properties.Resources.smr_non11; break;
                        case 12: img = Properties.Resources.smr_non12; break;
                        case 13: img = Properties.Resources.smr_non13; break;
                        case 14: img = Properties.Resources.smr_non14; break;
                        case 15: img = Properties.Resources.smr_non15; break;
                        case 16: img = Properties.Resources.smr_non16; break;
                        case 17: img = Properties.Resources.smr_non17; break;
                        case 18: img = Properties.Resources.smr_non18; break;
                        case 19: img = Properties.Resources.smr_non19; break;
                        case 20: img = Properties.Resources.smr_non20; break;
                        case 21: img = Properties.Resources.smr_non21; break;
                        case 22: img = Properties.Resources.smr_non22; break;
                        case 23: img = Properties.Resources.smr_non23; break;
                        case 24: img = Properties.Resources.smr_non24; break;
                        case 25: img = Properties.Resources.smr_non25; break;
                        case 26: img = Properties.Resources.smr_non26; break;
                        case 27: img = Properties.Resources.smr_non27; break;
                        case 28: img = Properties.Resources.smr_non28; break;
                        case 29: img = Properties.Resources.smr_non29; break;
                        case 30: img = Properties.Resources.smr_non30; break;
                        case 31: img = Properties.Resources.smr_non31; break;
                        case 32: img = Properties.Resources.smr_non32; break;
                        case 33: img = Properties.Resources.smr_non33; break;
                        case 34: img = Properties.Resources.smr_non34; break;
                        case 35: img = Properties.Resources.smr_non35; break;
                        case 36: img = Properties.Resources.smr_non36; break;
                    }
                    p[i - 1].Image = img;
                }
                for (int i = 0; i < 36; i++) {
                    if (ss1[i] != "PASS" && ss1[i] != "FAIL") continue;
                    if (ss1[i] == "PASS") {
                        switch (i + 1) {
                            case 1: img = Properties.Resources.smr_pass1; break;
                            case 2: img = Properties.Resources.smr_pass2; break;
                            case 3: img = Properties.Resources.smr_pass3; break;
                            case 4: img = Properties.Resources.smr_pass4; break;
                            case 5: img = Properties.Resources.smr_pass5; break;
                            case 6: img = Properties.Resources.smr_pass6; break;
                            case 7: img = Properties.Resources.smr_pass7; break;
                            case 8: img = Properties.Resources.smr_pass8; break;
                            case 9: img = Properties.Resources.smr_pass9; break;
                            case 10: img = Properties.Resources.smr_pass10; break;
                            case 11: img = Properties.Resources.smr_pass11; break;
                            case 12: img = Properties.Resources.smr_pass12; break;
                            case 13: img = Properties.Resources.smr_pass13; break;
                            case 14: img = Properties.Resources.smr_pass14; break;
                            case 15: img = Properties.Resources.smr_pass15; break;
                            case 16: img = Properties.Resources.smr_pass16; break;
                            case 17: img = Properties.Resources.smr_pass17; break;
                            case 18: img = Properties.Resources.smr_pass18; break;
                            case 19: img = Properties.Resources.smr_pass19; break;
                            case 20: img = Properties.Resources.smr_pass20; break;
                            case 21: img = Properties.Resources.smr_pass21; break;
                            case 22: img = Properties.Resources.smr_pass22; break;
                            case 23: img = Properties.Resources.smr_pass23; break;
                            case 24: img = Properties.Resources.smr_pass24; break;
                            case 25: img = Properties.Resources.smr_pass25; break;
                            case 26: img = Properties.Resources.smr_pass26; break;
                            case 27: img = Properties.Resources.smr_pass27; break;
                            case 28: img = Properties.Resources.smr_pass28; break;
                            case 29: img = Properties.Resources.smr_pass29; break;
                            case 30: img = Properties.Resources.smr_pass30; break;
                            case 31: img = Properties.Resources.smr_pass31; break;
                            case 32: img = Properties.Resources.smr_pass32; break;
                            case 33: img = Properties.Resources.smr_pass33; break;
                            case 34: img = Properties.Resources.smr_pass34; break;
                            case 35: img = Properties.Resources.smr_pass35; break;
                            case 36: img = Properties.Resources.smr_pass36; break;
                        }
                        p[i].Image = img;
                    } else {
                        switch (i + 1) {
                            case 1: img = Properties.Resources.smr_fail1; break;
                            case 2: img = Properties.Resources.smr_fail2; break;
                            case 3: img = Properties.Resources.smr_fail3; break;
                            case 4: img = Properties.Resources.smr_fail4; break;
                            case 5: img = Properties.Resources.smr_fail5; break;
                            case 6: img = Properties.Resources.smr_fail6; break;
                            case 7: img = Properties.Resources.smr_fail7; break;
                            case 8: img = Properties.Resources.smr_fail8; break;
                            case 9: img = Properties.Resources.smr_fail9; break;
                            case 10: img = Properties.Resources.smr_fail10; break;
                            case 11: img = Properties.Resources.smr_fail11; break;
                            case 12: img = Properties.Resources.smr_fail12; break;
                            case 13: img = Properties.Resources.smr_fail13; break;
                            case 14: img = Properties.Resources.smr_fail14; break;
                            case 15: img = Properties.Resources.smr_fail15; break;
                            case 16: img = Properties.Resources.smr_fail16; break;
                            case 17: img = Properties.Resources.smr_fail17; break;
                            case 18: img = Properties.Resources.smr_fail18; break;
                            case 19: img = Properties.Resources.smr_fail19; break;
                            case 20: img = Properties.Resources.smr_fail20; break;
                            case 21: img = Properties.Resources.smr_fail21; break;
                            case 22: img = Properties.Resources.smr_fail22; break;
                            case 23: img = Properties.Resources.smr_fail23; break;
                            case 24: img = Properties.Resources.smr_fail24; break;
                            case 25: img = Properties.Resources.smr_fail25; break;
                            case 26: img = Properties.Resources.smr_fail26; break;
                            case 27: img = Properties.Resources.smr_fail27; break;
                            case 28: img = Properties.Resources.smr_fail28; break;
                            case 29: img = Properties.Resources.smr_fail29; break;
                            case 30: img = Properties.Resources.smr_fail30; break;
                            case 31: img = Properties.Resources.smr_fail31; break;
                            case 32: img = Properties.Resources.smr_fail32; break;
                            case 33: img = Properties.Resources.smr_fail33; break;
                            case 34: img = Properties.Resources.smr_fail34; break;
                            case 35: img = Properties.Resources.smr_fail35; break;
                            case 36: img = Properties.Resources.smr_fail36; break;
                        }
                        p[i].Image = img;
                    }
                }
            }
            if(s2 != "") {
                string[] ss2 = File.ReadAllLines("smr_show_results_tested_005.txt");
                Image img = Properties.Resources.smr_pass;
                for (int i = 1; i <= 36; i++) {
                    switch (i) {
                        case 1: img = Properties.Resources.smr_non_1; break;
                        case 2: img = Properties.Resources.smr_non_2; break;
                        case 3: img = Properties.Resources.smr_non_3; break;
                        case 4: img = Properties.Resources.smr_non_4; break;
                        case 5: img = Properties.Resources.smr_non_5; break;
                        case 6: img = Properties.Resources.smr_non_6; break;
                        case 7: img = Properties.Resources.smr_non_7; break;
                        case 8: img = Properties.Resources.smr_non_8; break;
                        case 9: img = Properties.Resources.smr_non_9; break;
                        case 10: img = Properties.Resources.smr_non_10; break;
                        case 11: img = Properties.Resources.smr_non_11; break;
                        case 12: img = Properties.Resources.smr_non_12; break;
                        case 13: img = Properties.Resources.smr_non_13; break;
                        case 14: img = Properties.Resources.smr_non_14; break;
                        case 15: img = Properties.Resources.smr_non_15; break;
                        case 16: img = Properties.Resources.smr_non_16; break;
                        case 17: img = Properties.Resources.smr_non_17; break;
                        case 18: img = Properties.Resources.smr_non_18; break;
                        case 19: img = Properties.Resources.smr_non_19; break;
                        case 20: img = Properties.Resources.smr_non_20; break;
                        case 21: img = Properties.Resources.smr_non_21; break;
                        case 22: img = Properties.Resources.smr_non_22; break;
                        case 23: img = Properties.Resources.smr_non_23; break;
                        case 24: img = Properties.Resources.smr_non_24; break;
                        case 25: img = Properties.Resources.smr_non_25; break;
                        case 26: img = Properties.Resources.smr_non_26; break;
                        case 27: img = Properties.Resources.smr_non_27; break;
                        case 28: img = Properties.Resources.smr_non_28; break;
                        case 29: img = Properties.Resources.smr_non_29; break;
                        case 30: img = Properties.Resources.smr_non_30; break;
                        case 31: img = Properties.Resources.smr_non_31; break;
                        case 32: img = Properties.Resources.smr_non_32; break;
                        case 33: img = Properties.Resources.smr_non_33; break;
                        case 34: img = Properties.Resources.smr_non_34; break;
                        case 35: img = Properties.Resources.smr_non_35; break;
                        case 36: img = Properties.Resources.smr_non_36; break;
                    }
                    p[36 - i].Image = img;
                }
                for (int i = 0; i < 36; i++) {
                    if (ss2[i] != "PASS" && ss2[i] != "FAIL") continue;
                    if (ss2[i] == "PASS") {
                        switch (i + 1) {
                            case 1: img = Properties.Resources.smr_pass_1; break;
                            case 2: img = Properties.Resources.smr_pass_2; break;
                            case 3: img = Properties.Resources.smr_pass_3; break;
                            case 4: img = Properties.Resources.smr_pass_4; break;
                            case 5: img = Properties.Resources.smr_pass_5; break;
                            case 6: img = Properties.Resources.smr_pass_6; break;
                            case 7: img = Properties.Resources.smr_pass_7; break;
                            case 8: img = Properties.Resources.smr_pass_8; break;
                            case 9: img = Properties.Resources.smr_pass_9; break;
                            case 10: img = Properties.Resources.smr_pass_10; break;
                            case 11: img = Properties.Resources.smr_pass_11; break;
                            case 12: img = Properties.Resources.smr_pass_12; break;
                            case 13: img = Properties.Resources.smr_pass_13; break;
                            case 14: img = Properties.Resources.smr_pass_14; break;
                            case 15: img = Properties.Resources.smr_pass_15; break;
                            case 16: img = Properties.Resources.smr_pass_16; break;
                            case 17: img = Properties.Resources.smr_pass_17; break;
                            case 18: img = Properties.Resources.smr_pass_18; break;
                            case 19: img = Properties.Resources.smr_pass_19; break;
                            case 20: img = Properties.Resources.smr_pass_20; break;
                            case 21: img = Properties.Resources.smr_pass_21; break;
                            case 22: img = Properties.Resources.smr_pass_22; break;
                            case 23: img = Properties.Resources.smr_pass_23; break;
                            case 24: img = Properties.Resources.smr_pass_24; break;
                            case 25: img = Properties.Resources.smr_pass_25; break;
                            case 26: img = Properties.Resources.smr_pass_26; break;
                            case 27: img = Properties.Resources.smr_pass_27; break;
                            case 28: img = Properties.Resources.smr_pass_28; break;
                            case 29: img = Properties.Resources.smr_pass_29; break;
                            case 30: img = Properties.Resources.smr_pass_30; break;
                            case 31: img = Properties.Resources.smr_pass_31; break;
                            case 32: img = Properties.Resources.smr_pass_32; break;
                            case 33: img = Properties.Resources.smr_pass_33; break;
                            case 34: img = Properties.Resources.smr_pass_34; break;
                            case 35: img = Properties.Resources.smr_pass_35; break;
                            case 36: img = Properties.Resources.smr_pass_36; break;
                        }
                        p[36 - i - 1].Image = img;
                    } else {
                        switch (i + 1) {
                            case 1: img = Properties.Resources.smr_fail_1; break;
                            case 2: img = Properties.Resources.smr_fail_2; break;
                            case 3: img = Properties.Resources.smr_fail_3; break;
                            case 4: img = Properties.Resources.smr_fail_4; break;
                            case 5: img = Properties.Resources.smr_fail_5; break;
                            case 6: img = Properties.Resources.smr_fail_6; break;
                            case 7: img = Properties.Resources.smr_fail_7; break;
                            case 8: img = Properties.Resources.smr_fail_8; break;
                            case 9: img = Properties.Resources.smr_fail_9; break;
                            case 10: img = Properties.Resources.smr_fail_10; break;
                            case 11: img = Properties.Resources.smr_fail_11; break;
                            case 12: img = Properties.Resources.smr_fail_12; break;
                            case 13: img = Properties.Resources.smr_fail_13; break;
                            case 14: img = Properties.Resources.smr_fail_14; break;
                            case 15: img = Properties.Resources.smr_fail_15; break;
                            case 16: img = Properties.Resources.smr_fail_16; break;
                            case 17: img = Properties.Resources.smr_fail_17; break;
                            case 18: img = Properties.Resources.smr_fail_18; break;
                            case 19: img = Properties.Resources.smr_fail_19; break;
                            case 20: img = Properties.Resources.smr_fail_20; break;
                            case 21: img = Properties.Resources.smr_fail_21; break;
                            case 22: img = Properties.Resources.smr_fail_22; break;
                            case 23: img = Properties.Resources.smr_fail_23; break;
                            case 24: img = Properties.Resources.smr_fail_24; break;
                            case 25: img = Properties.Resources.smr_fail_25; break;
                            case 26: img = Properties.Resources.smr_fail_26; break;
                            case 27: img = Properties.Resources.smr_fail_27; break;
                            case 28: img = Properties.Resources.smr_fail_28; break;
                            case 29: img = Properties.Resources.smr_fail_29; break;
                            case 30: img = Properties.Resources.smr_fail_30; break;
                            case 31: img = Properties.Resources.smr_fail_31; break;
                            case 32: img = Properties.Resources.smr_fail_32; break;
                            case 33: img = Properties.Resources.smr_fail_33; break;
                            case 34: img = Properties.Resources.smr_fail_34; break;
                            case 35: img = Properties.Resources.smr_fail_35; break;
                            case 36: img = Properties.Resources.smr_fail_36; break;
                        }
                        p[36 - i - 1].Image = img;
                    }
                }
            }
            File.Delete("smr_show_results_tested_005.txt");
            File.Delete("smr_show_results_tested_006.txt");
            textBox1.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            this.Focus();
            this.Activate();
            this.Show();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e) {
            this.Close();
        }
    }
}
