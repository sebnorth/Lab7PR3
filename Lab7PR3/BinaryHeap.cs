using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7PR3
{
    class BinaryHeap
    {
        int[] arr;
        int sizeOfHeap;

        public BinaryHeap(int n) {

            this.arr = new int[n + 1];
            this.sizeOfHeap = 0;
        }

        public void AddToHeap(int item) {

            sizeOfHeap++;
            arr[sizeOfHeap] = item;
            moveUp(sizeOfHeap);
        }

        public void AddToArray(int item) {

            sizeOfHeap++;
            arr[sizeOfHeap] = item;
        }

        public void BuildMaxHeap() {

            for (int i = sizeOfHeap/2; i >= 1; i--)
            {
                // TODO heapify
            }
        }



        public void Swap(int x, int y) {

            int kopia = arr[x];
            arr[x] = arr[y];
            arr[y] = kopia;
        }

        public int Parent(int i) {

            return i / 2;
        }
        
        public void moveUp(int i) {

            while (Parent(i)>=1 && arr[i] > arr[Parent(i)])
            {
                Swap(i, Parent(i));
                i = Parent(i); 
            }

        }

        public void WypiszKopiec() {

            for (int i = 1; i <= sizeOfHeap; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
        }
    }
}
