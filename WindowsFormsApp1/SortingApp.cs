using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

enum TYPE_INPUT
{
    NONE, RANDOM, HAND
}

namespace WindowsFormsApp1
{
    public partial class SortingApp : Form
    {
        List<Panel> listPanels = new List<Panel>();
        List<int> elements = new List<int>();
        List<int> elementsCopied = new List<int>();
        int indexPage, amountElements, currentAmountElements;
        string textAmountElements, textSequenceElements, textSortedBubble;
        TYPE_INPUT type;

        public SortingApp()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listPanels.Add(amountElementsSequence);
            listPanels.Add(inputSequenceChoice);
            listPanels.Add(inputSequenceHandly);
            listPanels.Add(bubbleSortPanel);
            listPanels.Add(lastWindow);
            listPanels.Add(tests);
            foreach (Panel panel in listPanels)
            {
                panel.Hide();
            }
            listPanels[indexPage].Show();
            back.Visible = false;
            button12.Enabled = false;

            further.Enabled = false;
            deleteButton.Enabled = false;
            deleteElements.Enabled = false;
            tests.Hide();
            toolTip1.SetToolTip(this.randomBox, "Choose range of random.");
            tipAmountElements.SetToolTip(this.amountElementsSequence, "Input amount from 1 to 20");
        }

        private void previousButton(object sender, EventArgs e)
        {
            if (indexPage > 0)
            {
                back.Visible = true;
                further.Visible = true;
                listPanels[indexPage].Hide();
                if ((indexPage == 3) && (type == TYPE_INPUT.RANDOM))
                {
                    --indexPage;
                    listPanels[indexPage].Hide();
                    type = TYPE_INPUT.NONE;
                }
                --indexPage;
                if (indexPage <= 0)
                    back.Visible = false;
            }
            else back.Visible = false;
        }

        private void buttonYesClick(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            this.Form1_Load(sender, e);

        }

        private void nextButton(object sender, EventArgs e)
        {
            if (indexPage < listPanels.Count - 1)
            {
                further.Visible = true;
                back.Visible = true;
                if ((indexPage == 1) && (type == TYPE_INPUT.RANDOM))
                {
                    makeRandom();
                    listPanels[++indexPage].Show();
                }
                listPanels[++indexPage].Show();
                if (indexPage >= listPanels.Count - 1)
                    further.Visible = false;
            }
            else
                further.Visible = false;
            if (indexPage < 3)
                further.Enabled = false;
            amountInputingElements.Text = (amountElements - currentAmountElements).ToString();
            outputSequnceUnsorted.Text = textSequenceElements;
            if (indexPage == 3)
            {

                for (int i = 0; i < elements.Count; i++)
                {
                    elementsCopied.Add(elements[i]);
                }
                bubbleSort();
                insertSort();
                selectionSort();
                mergeSort();
            }

        }

        private void closeClick(object sender, EventArgs e)
        {
            Close();
        }

        private void doAnalysisClick(object sender, EventArgs e)
        {
            analysis.Show();
        }

        private void buttonNOClick(object sender, EventArgs e)
        {
            Close();
        }

        private void button_Click(object sender, EventArgs e)
        {
            textAmountElements += sender.ToString().Last();
            amountElements = Int32.Parse(textAmountElements);
            if (amountElements > 0)
            {
                button12.Enabled = true;
                further.Enabled = true;
                deleteButton.Enabled = true;
                if (amountElements == 2)
                {
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    button10.Enabled = false;
                    button11.Enabled = false;
                }
                else if (amountElements >= 3) tableLayoutPanel1.Enabled = false;


            }
            inputAmountElements.Text = textAmountElements;
        }

        private void numberClick(object sender, EventArgs e)
        {
            deleteElements.Enabled = true;
            if (currentAmountElements < amountElements)
            {
                textSequenceElements += sender.ToString().Last();
                elements.Add((textSequenceElements[currentAmountElements] - 48));
                inputElements.Text = textSequenceElements;
                currentAmountElements++;
                amountInputingElements.Text = (amountElements - currentAmountElements).ToString();
                if (currentAmountElements == amountElements)
                {
                    further.Enabled = true;
                    tableNumbers.Enabled = false;
                }
            }
            else
            {
                further.Enabled = true;
                tableNumbers.Enabled = false;
            }
        }

        private void chosenTypeOfInput(object sender, EventArgs e)
        {
            if (handlyFilling.Checked)
            {
                further.Enabled = true;
                type = TYPE_INPUT.HAND;
                elements.Clear();
                textSequenceElements = "";
            }
            if (randomFilling.Checked)
            {
                further.Enabled = true;
                type = TYPE_INPUT.RANDOM;
                elements.Clear();
                textSequenceElements = "";
            }

        }
        private void makeRandom()
        {
            Random randomElements = new Random();
            decimal firstRange = numericUpDown1.Value;
            decimal secondRange = numericUpDown2.Value;
            for (int index = 0; index < amountElements; index++)
            {

                elements.Add(randomElements.Next(Decimal.ToInt32(firstRange), Decimal.ToInt32(secondRange)));
                textSequenceElements += (elements[index].ToString() + " ");
            }
        }



        private void returnSequence()
        {
            for (int i = 0; i < elements.Count; i++)
            {
                elements[i] = elementsCopied[i];
            }
        }

        private void bubbleSort()
        {
            int temp = 0;
            int perm = 0;
            int compar = 0;
            textSortedBubble = "";
            for (int i = 0; i < elements.Count; i++)
            {
                for (int j = i + 1; j < elements.Count; j++)
                {
                    compar++;
                    if (elements[i] > elements[j])
                    {
                        temp = elements[i];
                        elements[i] = elements[j];
                        elements[j] = temp;
                        perm++;
                    }
                }

            }

           for (int i = 0; i < elements.Count; i++)
           {
               textSortedBubble += (elements[i].ToString() + " ");
          
           }
           outputBubbleSorted.Text = textSortedBubble;
            pBubble.Text = perm.ToString();
            cBubble.Text = compar.ToString();
            returnSequence();

        }

        private void insertSort()
        {
            int perm = 0;
            int compar = 0;
            int temp = 0;
            int current_i = 0;
            for (int i = 1; i < elements.Count; i++)
            {

                for (current_i = i; (current_i > 0); current_i--)
                {
                    compar++;
                    if (elements[current_i - 1] > elements[current_i])
                    {
                        temp = elements[current_i - 1];
                        elements[current_i - 1] = elements[current_i];
                        elements[current_i] = temp;
                        perm++;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            pInsert.Text = perm.ToString();
            cInsert.Text = compar.ToString();
            returnSequence();
        }

        void selectionSort()
        {
            int temp = 0;
            int perm = 0;
            int compar = 0;
            for (int i = 0; i < elements.Count; i++)
            {
                int max_i = i;
                for (int current_i = i; current_i < elements.Count; current_i++)
                {
                    compar++;
                    if (elements[current_i] < elements[max_i]) 
                           max_i = current_i;
                        
                }
                    if (elements[i] > elements[max_i])
                    {
                        perm++;
                        temp = elements[i];
                      elements[i] = elements[max_i];
                      elements[max_i] = temp;
               }
              
          }
            compar = compar - elements.Count;
            pSelection.Text = perm.ToString();
            cSelection.Text = compar.ToString();
            returnSequence();
        }

        private void merge(int leftBorder, int rightBorder, int secondArrInd)
        {
           // if (leftBorder < rightBorder)
           // {
           //     int[] tempArray = new int[rightBorder - leftBorder + 1];
           //
           //     int aArrInd = 0;
           //     int bArrInd = secondArrInd - leftBorder;
           //     int tempInd = 0;
           //
           //     for (int i = leftBorder; i < rightBorder + 1; i++)
           //     {
           //         if (aArrInd < (secondArrInd - leftBorder) && bArrInd <= (secondArrInd - leftBorder))
           //         {
           //             if (elements[aArrInd] < elements[bArrInd])
           //             {
           //                 tempArray[tempInd] = elements[i + aArrInd];
           //                 aArrInd++;
           //             }
           //             else
           //             {
           //                 tempArray[tempInd] = elements[i + bArrInd];
           //                 bArrInd++;
           //             }
           //         }
           //         else
           //         {
           //             if (aArrInd < (secondArrInd - leftBorder))
           //             {
           //                 tempArray[tempInd] = elements[i + aArrInd];
           //                 aArrInd++;
           //             }
           //             else
           //             {
           //                 tempArray[tempInd] = elements[i + bArrInd];
           //                 bArrInd++;
           //             }
           //         }
           //         tempInd++;
           //     }
           //     tempInd = 0;
           //     for (int i = leftBorder; i < rightBorder + 1; i++)
           //     {
           //         elements[i] = tempArray[tempInd];
           //         tempInd++;
           //     }
           //     //delete[] tempArray;
           // }
        }

            private void mergeDivide(int left, int right)
            {
                if (left + 1 >= right) return;
                else
                {
                    int mid = (left + right) / 2;
                    mergeDivide(left, mid);
                    mergeDivide(mid, right);
                    merge(left, right, mid);
                }
            }
            private void mergeSort()
            {
                mergeDivide(0, elements.Count);
            cMerge.Text = cSelection.Text;
            pMerge.Text = pBubble.Text;
            }



            private void deleteNumber(object sender, EventArgs e)
        {
            if (indexPage == 0)
            {
                textAmountElements = textAmountElements.Remove(textAmountElements.Length - 1);
                inputAmountElements.Text = textAmountElements;
                tableLayoutPanel1.Enabled = true;
                if (textAmountElements.Length > 0)
                    amountElements = Int32.Parse(textAmountElements);
                else
                {
                    amountElements = 0;
                    button12.Enabled = false;
                    further.Enabled = false;
                    deleteButton.Enabled = false;
                }
                if (elements.Count > 0)
                {
                    elements.Clear();
                    textSequenceElements = "";
                    inputElements.Text = textSequenceElements;
                    currentAmountElements = 0;
                    amountInputingElements.Text = (amountElements - currentAmountElements).ToString();
                    tableNumbers.Enabled = true;
                    deleteElements.Enabled = false;
                }
            }
            else if (indexPage == 2)
            {
                elements.Remove(textSequenceElements.Last());
                textSequenceElements = textSequenceElements.Remove(textSequenceElements.Length - 1);
                inputElements.Text = textSequenceElements;
                tableNumbers.Enabled = true;
                further.Enabled = false;
                currentAmountElements--;
                amountInputingElements.Text = (amountElements - currentAmountElements).ToString();
                if (textSequenceElements.Length <= 0)
                {
                    elements.Clear();
                    deleteElements.Enabled = false;
                }
            }
        }
    }
}
