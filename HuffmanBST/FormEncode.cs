using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuffmanBST
{
    public partial class FormEncode : Form
    {
        Queue<HuffmanNode> queueTempNodes = new Queue<HuffmanNode>(); // Queue yg digunakan sebagai patokan pembuatan tree
        
        List<HuffmanNode> listTempOrderedNodes = new List<HuffmanNode>(); // List pembantu untuk mengurutkan queue berdasarkan frekuensi karakter.

        List<HuffmanNode> listFixedNodes = new List<HuffmanNode>(); // Node Utama Sebagai Hasil Display

        List<EncodedChar> listBinary = new List<EncodedChar>(); // List berisikan data karakter yg telah di Encode, berserta binernya.

        string input = ""; // String sebagai patokan input tulisan

        public FormEncode()
        {
            InitializeComponent();
        }

        private void FormEncode_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Enabled = true;
        }

        private void buttonEncode_Click(object sender, EventArgs e) // Pembentukan HuffmanTree dari awal input kata
        {
            // Pastikan semua list bersih saat akan melakukan encoding
            listTempOrderedNodes.Clear();
            queueTempNodes.Clear();
            listFixedNodes.Clear();
            listBinary.Clear();
            listBoxNodeList.Items.Clear();

            input = textBoxInput.Text; 
            while (input != "") // Selama tulisan string input tidak kosong, jalani program IDENTIFIKASI KARAKTER DAN FREKUENSI
            {
                string txt = input.Substring(0, 1); // Pengambilan huruf pertama dari input
                input = input.Remove(0, 1);         // Pembuangan huruf pertama yang telah dibaca dr input

                if (listTempOrderedNodes.Count > 0) // Bila list pembantu tidak kosong
                {
                    bool valid = false;
                    for (int i = 0; i < listTempOrderedNodes.Count; i++) // Analisa apakah dalam list sudah terdaftar karakter yang sama dengan yang akan dibaca
                    {
                        if (listTempOrderedNodes[i].NodeString == txt) // Bila ada karakter yang sama dalam list, cukup tambah nilai frekuensinya
                        {
                            listTempOrderedNodes[i].Frequency += 1;     
                            valid = true;
                            break;
                        }
                    }
                    if (!valid) NewNode(txt);   // Bila tidak ditemukan karakter yang sama dalam list, buat Node baru
                }
                else NewNode(txt); // Pembuatan Node paling pertama saat list pembantu masih kosongan
            }

            RefreshOrder(); // Method untuk mengurutkan kembali queue berdasarkan jumlah frekuensi.

            // Setelah semua karakter berhasil diidentifikasi frekuensinya. buat parent untuk semua Node yang belum 
            // memiliki parent. Buat hingga parent teratas merepresentasikan semua karakter yang ada.
            while(queueTempNodes.Count>1)
            {
                HuffmanNode leftNode = queueTempNodes.Dequeue();    // Node sebagai Left Child, dan keluarkan node terkait dari queue
                HuffmanNode rightNode = queueTempNodes.Dequeue();   // Node sebagai Right Child, dan keluarkan node terkait dari queue
                HuffmanNode newParent = new HuffmanNode();          // Buat Node parent baru
                newParent.NodeString = leftNode.NodeString + rightNode.NodeString;  // Buat parent merepresentasikan semua karakter dari kedua childnya.
                newParent.Frequency = leftNode.Frequency + rightNode.Frequency;     // Buat parent merepresentasikan akumulasi frekuensi dari kedua childnya.
                newParent.Left = leftNode;
                newParent.Right = rightNode;
                queueTempNodes.Enqueue(newParent);  // Masukkan parent dalam Queue
                listFixedNodes.Add(newParent);      // Masukkan parent dalam list node yang akan didisplay
                RefreshOrder();                     // Urutkan kembali queue berdasarkan frekuensi masing2 node
            }

            dataGridViewEncodedChars.Rows.Clear();  // Bersihkan Tabel Biner

            for (int i=0; i<listFixedNodes.Count; i++)  // Lakukan pembacaan node display untuk menampilkan dalam listBox daftar node.
            {
                listBoxNodeList.Items.Add("Node\t\t: " + listFixedNodes[i].NodeString);
                listBoxNodeList.Items.Add("Frequency\t: " + listFixedNodes[i].Frequency);

                if (listFixedNodes[i].Left != null) listBoxNodeList.Items.Add("Left\t\t: " + listFixedNodes[i].Left.NodeString);
                else listBoxNodeList.Items.Add("Left\t\t: " + "Null");
                if (listFixedNodes[i].Right != null) listBoxNodeList.Items.Add("Right\t\t: " + listFixedNodes[i].Right.NodeString);
                else listBoxNodeList.Items.Add("Right\t\t: " + "Null");

                listBoxNodeList.Items.Add("");

                if (listFixedNodes[i].NodeString.Length == 1) // Bila Node merepresentasikan karakter tunggal, lakukan identifikasi biner untuk ENCODED CHAR
                {
                    EncodedChar en = new EncodedChar();
                    en.Character = listFixedNodes[i].NodeString;    // Ambil tulisan dari Node berkarakter tunggal
                    en.Binary = AnalyzeBinary(en.Character, listFixedNodes[listFixedNodes.Count-1]);    // Lakukan Metode analisa biner untuk karakter terkait
                    listBinary.Add(en); // Masukkan ENCODED CHAR ke list biner
                    dataGridViewEncodedChars.Rows.Add(en.Character, en.Binary); // Masukkan pula ENCODED CHAR ke tabel form
                }
            }

            input = textBoxInput.Text;  // Lakukan pembacaan sekali lagi dari input untuk menentukan biner keseluruhan sebagai hasil output
            string output = "";
            while (input != "") // Lakukan pembacaan selama teks input tidak kosong.
            {
                string txt = input.Substring(0, 1); // Pengambilan huruf pertama dari input
                input = input.Remove(0, 1);         // Pembuangan huruf pertama yang telah dibaca dr input
                for (int i = 0; i < listBinary.Count; i++)  // Lakukan pembacaan pada seluruh data binary
                {
                    if (listBinary[i].Character == txt) output = output + listBinary[i].Binary; // Bila ada data yang berkarakter cocok dengan huruf pertama, ambil nilai biner dan tambahkan ke output
                }
            }
            textBoxOutput.Text = output;
        }

        private void buttonDecode_Click(object sender, EventArgs e) // Pengubahan input dari huruf ke biner berdasarkan daftar encoded binary yang telah dibentuk
        {
            DecodeMethod1();
        }

        private void button1_Click(object sender, EventArgs e) // Pengubahan input dari biner ke huruf berdasarkan daftar encoded binary yang telah dibentuk
        {
            DecodeMethod2();
        }

        public void NewNode(string p) // Method untuk membuat node baru tanpa anak (Representasi karakter tunggal)
        {
            HuffmanNode node = new HuffmanNode();
            node.NodeString = p;
            node.Frequency = 1;
            node.Left = null;
            node.Right = null;
            listFixedNodes.Add(node);       // Node Utama Sebagai Hasil Display
            listTempOrderedNodes.Add(node); // List pembantu 
        }

        public void RefreshOrder() // Method untuk mengurutkan queue berdasarkan frekuensi tiap data yang ada
        {
            int value = 1;
            if (queueTempNodes.Count > 0) // Bila queue berisi, kosongkan list sementara, dan pindahkan semua isi queue padalist sementara
            {
                listTempOrderedNodes.Clear();
                while (queueTempNodes.Count != 0) listTempOrderedNodes.Add(queueTempNodes.Dequeue());
            }
            while(queueTempNodes.Count < listTempOrderedNodes.Count) // Selama isi queue masih lebih kecil drpd list sementara lakukan operasi
            {
                for (int i=0; i<listTempOrderedNodes.Count; i++) // Dimulai dari nilai 1, masukkan semua data berfrekuensi 1 dalam list sementara ke queue.
                {
                    if (listTempOrderedNodes[i].Frequency == value) queueTempNodes.Enqueue(listTempOrderedNodes[i]); // Bila frekuensi data list sementara cocok, masukkan dalam queue
                }
                value++; // Bila tidak ada data yang sama dalam list, tambahkan nilai pembacaan.
            }
        }

        public string AnalyzeBinary(string txt, HuffmanNode parent) // Method untuk menganalisa biner hasil dari karakter tunggal terkait
        {
            HuffmanNode helper = parent; // Perhitungan pertama, helper di set dengan parent, dimana parent adalah root
            string returnValue = "";
            bool valid = true;
            while ((helper.Left != null || helper.Right != null) && valid) // Bila left atau right dari helper tidak kosong, dan validitas perhitungan masih true, lakukan analisa
            {
                if (helper.Left.NodeString.Contains(txt))
                {
                    helper = helper.Left; valid = true; returnValue = returnValue + "0"; // Bila string dari left child mengandung karakter yang dicari, tambahkan biner 0 pada hasil
                }
                else if (helper.Right.NodeString.Contains(txt))
                {
                    helper = helper.Right; valid = true; returnValue = returnValue + "1"; // Bila string dari right child mengandung karakter yang dicari, tambahkan biner 1 pada hasil
                }
                else valid = false; // Bila string yang dicari tidak ditemukan, false kan validitas, keluar dari while, serta munculkan error.
            }
            if (valid) return returnValue; // Kembalikan hasil kombinasi biner yang terbentuk
            else return "error";
        }

        public void DecodeMethod1() // Konversi dari hufur ke biner, berdasarkan list encoded char yang sudah terbentuk
        {
            input = textBoxInput.Text;
            string output = "";
            bool valid = true;
            while (input != "") // Selama teks input tidak null, lakukan operasi
            {
                string txt = input.Substring(0, 1); // Ambil karakter pertama dari input dan simpan dalam string
                input = input.Remove(0, 1); // Buang karakter pertama tersebut dari input (karakter sudah tersimpan dalam string sementara)
                bool available = false;     // Set available default sbg false
                for (int i = 0; i < listBinary.Count; i++)
                {
                    if (listBinary[i].Character == txt) // Cocokkan karakter yang tersimpan dalam string sementara dengan list encoded char yang ada
                    {
                        output = output + listBinary[i].Binary; // Bila ditemukan karakter yang dimaksud, ambil binernya, dan tambahkan di output
                        available = true;                       // Set pula available menjadi true untuk menunjukkan bahwa pencarian data berhasil
                    }
                }
                if (!available) valid = false; // Bila pencarian data tidak menemukan karakter yang dimaksud, langsung buat validitas menjadi false
            }
            if (valid) textBoxOutput.Text = output; // Bila valid, maka tampilkan output seperti biasa. Sebaliknya bila tidak valid, tampilkan error.
            else textBoxOutput.Text = "There's character that's unregistered in the Encoded Char List. Please make sure you only input phrases with registered character.";
        }

        public void DecodeMethod2() // Konversi dari biner ke huruf, berdasarkan list encoded char yang sudah terbentuk
        {
            if (listFixedNodes.Count > 0) // Pastikan dulu, tahap encoding sudah dilakukan untuk membuat list nodes.
            {
                input = textBoxInput.Text;
                string output = "";
                HuffmanNode root = new HuffmanNode();
                for (int i = 0; i < listFixedNodes.Count; i++) // Cari dulu, mana node yang merupakan root
                {                                              // Node tersebut adalah node yang merepresentasikan semua karakter yang ada.
                    if (root.NodeString.Length < listFixedNodes[i].NodeString.Length) root = listFixedNodes[i]; // Root adalah node dengan string terpanjang.
                }
                int repetition = input.Length; // Deklarasikan seberapa banyak repetisi yang harus dilakukan
                bool finished = false;         // Deklarasikan pula apakah analisa yang dilakukan berhasil (default false)
                HuffmanNode helper = new HuffmanNode();
                helper = root;                 // Pada awal perhitungan, set helper sebagai root.
                for (int j=0; j<repetition; j++)
                {
                    finished = false;   // Awal analisa, set finished menjadi false dulu, untuk mengindikasikan proses perhitungan yang belum selesai
                    string biner = "";
                    if (input != "") biner = input.Substring(0, 1); // Selama input tidak null, ambil karakter pertama (0 atau 1)
                    if (biner == "0" && helper.Left != null) 
                    {
                        helper = helper.Left;       // Bila karakter yang diperoleh 0, serta left tidak null, ubah helper menjadi left nya, 
                        input = input.Remove(0, 1); // serta lakukan pembuangan terhadap karakter pertama input.
                    }
                    else if (biner == "1" && helper.Right != null)
                    {
                        helper = helper.Right;      // Bila karakter yang diperoleh 1, serta right tidak null, ubah helper menjadi right nya,
                        input = input.Remove(0, 1); // serta lakukan pembuangan terhadap karakter pertama input.
                    }
                    if (helper.Left == null && helper.Right == null)
                    {                                           // Bila left null dan right juga null, berarti helper sudah mencapai leaf
                        output = output + helper.NodeString;    // Langsung ambil string dari helper, dan masukkan ke output.
                        helper = root;                          // Set helper kembali menjadi root
                        finished = true;                        // Set finished menjadi true, menunjukkan analisa mencari karakter berhasil dilakukan.
                    }
                }
                if (finished) textBoxOutput.Text = output; // Bila finished, analisa berhasil, tampilkan output
                else                                       // Bila tidak finished, berarti analisa seharusnya masih berlanjut, namun tidak ada biner tersisa dalam input, keluarkan error
                {
                    textBoxOutput.Text = "Unknown binary sequence detected. Make sure you've inputed the correct binary sequence according to the tree."
                        + "\n\n" + "Please note that binary numbers consists only number 0 and or 1";
                }
            }
            else // Bila belum pernah sama sekali melakukan encode, tidak akan dapat melakukan decode, karena decode dilakukan berdasarkan hasil encode.
            {
                textBoxOutput.Text = "Please encode something to make the HuffmanTree for decoding process...";
            }
        }

        private void buttonInstructions_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = "Untuk melakukan encode, masukkan input apapun dan tekan tombol encode." + "\n\n" +
                "Untuk melakukan decode metode pertama, masukkan huruf-huruf berdasarkan tabel encoded character yang ada..." + "\n" +
                "Bila karakter yang tidak terdaftar dalam tabel terdeteksi, decode metode pertama akan gagal dilakukan..." + "\n\n" +
                "Untuk melakukan decode metode kedua, masukkan biner (0 dan atau 1) berdasarkan tabel encoded character yang ada..." + "\n" +
                "Bila kombinasi biner tidak lengkap atau ada yang tidak diketahui, decode metode kedua akan gagal dilakukan...";
        }
    }
}
