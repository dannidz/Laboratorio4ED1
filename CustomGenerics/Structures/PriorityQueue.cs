﻿using System;
using System.Collections.Generic;
using CustomGenerics.Interfaces;

namespace CustomGenerics.Structures
{
    public class PriorityQueue<T> : INotLinearDataBase<T>  where T:IComparable
    {
        List<Node<T>> priorityQueue = new List<Node<T>>();
        public int size = -1;

        int reverseEquation(int x)
        {
            return (x - 1) / 2;
        }

        void change(int x, int y)
        {

            var aux = priorityQueue[x];
            priorityQueue[x] = priorityQueue[y];
            priorityQueue[y] = aux;

        }

        int left(int x)
        {
            return (x * 2) + 1;
        }

        int right(int x)
        {
            return (x * 2) + 2;
        }

        void maxHeap(int x)
        {
            int nleft = left(x);
            int nright = right(x);
            int h = x;

            if ((nleft <= size) && (priorityQueue[h].priority < priorityQueue[nleft].priority))
            {
                h = nleft;
            }
            if ((nright <= size) && priorityQueue[h].priority < priorityQueue[nright].priority)
            {
                h = nright;
            }
            if (h != x)
            {
                change(h, x);
                maxHeap(h);
            }
        }

        void heapMax(int x)
        {
            while ((x >= 0) && (priorityQueue[reverseEquation(x)].priority < priorityQueue[x].priority))
            {
                change(x, reverseEquation(x));
                x = reverseEquation(x);
            }
        }

        void Inserting(int p, string data)
        {
            Node<T> newNode = new Node<T>();
            newNode.priority = p;
            newNode.value = data;

            priorityQueue.Add(newNode);
            size++;
            heapMax(size);
        }

        
        string Deleting()
        {
            if (size > -1)
            {
                string data = priorityQueue[0].value;
                priorityQueue[0] = priorityQueue[size];
                priorityQueue.RemoveAt(size);
                size--;
                maxHeap(0);
                return data;
            }
            else
            {
                return "No hay tareas pendientes";
            }
        }

        public void Insert(int value, string data)
        {
            Inserting(value, data);
        }

        /// <summary>
        /// Return and delete the first values
        /// </summary>
        /// <returns></returns>
        public string Delete()
        {
            return Deleting();
        }

        /// <summary>
        /// Return the head value of the queue without remove it. 
        /// </summary>
        /// <returns></returns>
        public string Peek()
        {
            if (size > -1)
                return priorityQueue[0].value;
            else
                return "No hay tareas pendientes";
        }

        /// <summary>
        /// Crea una copia de la lista de prioridad.
        /// </summary>
        public List<Node<T>> CopyOfData()
        {
            var CopyDataList = this.priorityQueue;

            return CopyDataList;
        }
    }
}
