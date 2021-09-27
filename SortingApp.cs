using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        int indexPage, amountElements, currentAmountElements, perm, compar;
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
            listPanels.Add(inputSequenceRandomly);
            listPanels.Add(mergeSort);
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
            indexPage = 0;
            elements.Clear();
            amountElements = 0;
            textAmountElements = "";
            textSequenceElements = "";
            textSortedBubble = "";
            inputAmountElements.Text = textAmountElements;
            outputBubbleSorted.Text = textSortedBubble;
             foreach (Panel panel in listPanels)
            {
                panel.Hide();
            }
            
            listPanels[indexPage].Show();
            back.Visible = false;
            button12.Enabled = false;
            further.Enabled = false;
            further.Visible = true;
            deleteButton.Enabled = false;
            deleteElements.Enabled = false;
        }

        private void nextButton(object sender, EventArgs e)
        {
            if (indexPage < listPanels.Count - 1)
            {
                further.Visible = true;
                back.Visible = true;
                if ((indexPage == 1) && (type == TYPE_INPUT.RANDOM))
                {
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
            outputElements.Text = textSequenceElements;
            if (indexPage == 4)
            bubbleSort();
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
                randomFilling.Enabled = false;
                further.Enabled = true;
                type = TYPE_INPUT.HAND;
                elements.Clear();
                textSequenceElements = "";
            }
            else if (randomFilling.Checked)
            {
                handlyFilling.Enabled = false;
                further.Enabled = true;
                type = TYPE_INPUT.RANDOM;
                Random randomElements = new Random();
                elements.Clear();
                textSequenceElements = "";
                for (int index = 0; index < amountElements; index++)
                {
                    elements.Add(randomElements.Next(0, 9));
                    textSequenceElements += (elements[index].ToString() + " ");
                }
            }
            else if (!(handlyFilling.Checked && randomFilling.Checked))
            {
                further.Enabled = false;
                handlyFilling.Enabled = true;
                randomFilling.Enabled = true;
            }

        }

        private void bubbleSort()
        {
            int temp = 0;
            perm = 0;
            compar = 0;
            textSortedBubble = "";
            for (int i = 0; i < elements.Count; i++)
            {
                for (int j = i+1; j < elements.Count; j++)
                {
                    perm++;
                    if (elements[i] > elements[j])
                    {
                        temp = elements[i];
                        elements[i] = elements[j];
                        elements[j] = temp;
                        compar++;
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
        }

        private void insertSort()
        {
            int temp = 0;
            for (int i = 0; i < elements.Count; i++)
            {
                int key = elements[i];
                int j = i;
                perm++;
                if (j > 0)
                {
                    while(elements[j-1] > key)
                    {
                        elements[j - 1] = temp;
                        elements[j - 1] = elements[j];
                        elements[j] = temp;
                        compar++;
                        j--;
                    }
                }
                elements[j] = key;
            }
            
        }


        private void deleteNumber(object sender, EventArgs e)
        {
            if (indexPage == 0)
            {
                textAmountElements = textAmountElements.Remove(textAmountElements.Length - 1);
                inputAmountElements.Text = textAmountElements;
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
