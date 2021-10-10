using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

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
       private const int DEFAULT_TYPE = -1;
       private const int RANDOM = 0;
       private const int DECREASED = 1;
       private const int SEMISORTED = 2;
       public int permMerge = 0;
       public int compMerge = 0;

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
            analysis.Hide();
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
                bubbleSort(elements, pBubble, cBubble);
                insertSort(elements, pInsert, cInsert);
                selectionSort(elements, pSelection, cSelection);
                int[] arr = new int[elements.Count];
                changeType(elements, arr);
                arr = MergeSort(arr, pMerge, cMerge);
                //mergeSort(elements, pMerge, cMerge);
            }

        }

        private void closeClick(object sender, EventArgs e)
        {
            Close();
        }

        private void doAnalysisClick(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Form1_Load(sender, e);
            this.InitializeComponent();
            analysis.Show();
        }


        private void buttonSort(object sender, EventArgs e)
        {
            int selectedIndex = chosenTypeOfArray.SelectedIndex;
            List<int> tempInt = new List<int>();
            List<int> copyTempInt = new List<int>();
            int tempAmountElements = Decimal.ToInt32(numericAmount.Value);
            compMerge = 0;
            permMerge = 0;
            resultText.Text = "The most optimal sort is";
            switch (selectedIndex)
            {
                case RANDOM:
                    {
                        Random randomElements = new Random();
                        for (int index = 0; index < tempAmountElements; index++)
                        {
                            tempInt.Add(randomElements.Next(0, 100));
                            copyTempInt.Add(tempInt[index]);
                        }
                        break;
                    }
                case DECREASED:
                    {
                        Random randomElements = new Random();
                        for (int index = 0; index < tempAmountElements; index++)
                        {
                            tempInt.Add(randomElements.Next(0, 100));
                            copyTempInt.Add(tempInt[index]);
                        }
                        copyTempInt.Sort();
                        copyTempInt.Reverse();
                        break;
                    }
            }

            if(tempInt.Count > 1)
            {
                bubbleSort(tempInt, bubbleP, bubbleC);
                for (int index = 0; index < tempAmountElements; index++)
                {
                    tempInt[index] = copyTempInt[index];
                }
                insertSort(tempInt, insertP, insertC);
                for (int index = 0; index < tempAmountElements; index++)
                {
                    tempInt[index] = copyTempInt[index];
                }
                selectionSort(tempInt, selectionP, selectionC);
                for (int index = 0; index < tempAmountElements; index++)
                {
                    tempInt[index] = copyTempInt[index];
                }
                int[] arr = new int[tempAmountElements];
                changeType(tempInt, arr);
                arr = MergeSort(arr, mergeP, mergeC);
                int resultSort = Int32.Parse(mergeP.Text) + Int32.Parse(mergeC.Text);
                resultText.Text += " merge sort: " + resultSort.ToString();
            }
           
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


         Int32[] Merge(Int32[] arr1, Int32[] arr2)
        {
            Int32 ptr1 = 0, ptr2 = 0;
            Int32[] merged = new Int32[arr1.Length + arr2.Length];

            for (Int32 i = 0; i < merged.Length; ++i)
            {
                if (ptr1 < arr1.Length && ptr2 < arr2.Length)
                {
                    compMerge++;
                    merged[i] = arr1[ptr1] > arr2[ptr2] ? arr2[ptr2++] : arr1[ptr1++];
                    permMerge++;
                }
                else
                {
                    compMerge++;
                    merged[i] = ptr2 < arr2.Length ? arr2[ptr2++] : arr1[ptr1++];
                    permMerge++;
                }
            }
            return merged;
        }

         Int32[] MergeSort(Int32[] array, TextBox cMerge, TextBox pMerge)
        {
            
            if (array.Length == 1)
            {
                compMerge++;
                return array;
            }
            Int32 middle = array.Length / 2;
            cMerge.Text = compMerge.ToString();
            pMerge.Text = permMerge.ToString();
            return Merge(MergeSort(array.Take(middle).ToArray(), cMerge, pMerge),
                MergeSort(array.Skip(middle).ToArray(), cMerge, pMerge));
        }

        private void changeType(List<int> el, Int32[] array)
        {
            for (int i = 0; i < el.Count; i++)
            {
                array[i] = el[i];
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

        private void bubbleSort(List <int> elements, TextBox pBubble, TextBox cBubble)
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

        private void insertSort(List<int> elements, TextBox pInsert, TextBox cInsert)
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

        void selectionSort(List<int> elements, TextBox pSelection, TextBox cSelection)
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

        //private void merge(List<int> elements, int leftBorder, int rightBorder, int secondArrInd)
        //{
        //    if (leftBorder < rightBorder)
        //    {
        //        int[] tempArray = new int[rightBorder - leftBorder + 1];

        //        int aArrInd = 0;
        //        int bArrInd = secondArrInd - leftBorder;
        //        int tempInd = 0;
        //        for (int i = leftBorder; i < rightBorder + 1; i++)
        //        {
        //            tempArray[tempInd] = elements[i];
        //            tempInd++;
        //        }

        //        for (int i = leftBorder; i < rightBorder + 1; i++)
        //        {
        //            if (aArrInd < secondArrInd && bArrInd <= rightBorder)
        //            {
        //                if (tempArray[aArrInd] < tempArray[bArrInd])
        //                {
        //                    elements[i] = tempArray[aArrInd];
        //                    aArrInd++;
        //                }
        //                else
        //                {
        //                    elements[i] = tempArray[bArrInd];
        //                    bArrInd++;
        //                }
        //            }
        //            else
        //            {
        //                if (aArrInd < secondArrInd)
        //                {
        //                    elements[i] = tempArray[aArrInd];
        //                    aArrInd++;
        //                }
        //                else
        //                {
        //                    elements[i] = tempArray[bArrInd];
        //                    bArrInd++;
        //                }
        //            }
        //        }
        //        //delete[] tempArray;
        //    }
        //}

        //private void mergeDivide(List<int> elements,int left, int right)
        //{
        //    if (left < right)
        //    {
        //        int mid = left + (left + right) / 2;
        //        mergeDivide(elements,left, mid);
        //        mergeDivide(elements,mid + 1, right);
        //        merge(elements,left, right, mid+1);
        //    }
        //}
    
        //private void mergeSort(List<int> elements, TextBox pMerge, TextBox cMerge)
        //{
        //    mergeDivide(elements, 0, elements.Count-1);
        //    cMerge.Text = cSelection.Text + selectionC.Text;
        //    pMerge.Text = pBubble.Text + bubbleP.Text;
        //}



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
