using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_1
{
    class Document
    {
        public string Text { get; set; }

        public void SetText(string text)
        {
            Text = text;
        }

        public string toString()
        {
            return Text;
        }

        public  bool ContainsKeyword(Document docObject, string keyword)
        {
            if(docObject.toString().IndexOf(keyword, 0) >= 0)
            {
                return true;
            }

            return false;
        }
    }
}
