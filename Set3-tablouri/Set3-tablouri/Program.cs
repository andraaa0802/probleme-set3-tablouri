using System;

namespace Set3_tablouri
{
    class Program
    {
        static void Main(string[] args)
        {
            int optiune;

            Console.WriteLine("1.Calculati suma elementelor unui vector de n numere citite de la tastatura. Rezultatul se va afisa pe ecran. \n");
            Console.WriteLine("2.Se da un vector cu n elemente si o valoare k. Se cere sa se determine prima pozitie din vector pe care apare k. Daca k nu apare in vector rezultatul va fi -1.  \n");
            Console.WriteLine("3.Sa se determine pozitiile dintr-un vector pe care apar cel mai mic si cel mai mare element al vectorului. Pentru extra-credit realizati programul efectuand 3n/2 comparatii (in cel mai rau caz).  \n");
            Console.WriteLine("4.Deteminati printr-o singura parcurgere, cea mai mica si cea mai mare valoare dintr-un vector si de cate ori apar acestea.  \n");
            Console.WriteLine("5.Se da un vector cu n elemente, o valoare e si o pozitie din vector k. Se cere sa se insereze valoarea e in vector pe pozitia k. Primul element al vectorului se considera pe pozitia zero.  \n");
            Console.WriteLine("6.Se da un vector cu n elemente si o pozitie din vector k. Se cere sa se stearga din vector elementul de pe pozitia k. Prin stergerea unui element, toate elementele din dreapta lui se muta cu o pozitie spre stanga.  \n ");
            Console.WriteLine("7.Reverse. Se da un vector nu n elemente. Se cere sa se inverseze ordinea elementelor din vector. Prin inversare se intelege ca primul element devine ultimul, al doilea devine penultimul etc. \n");
            Console.WriteLine("8.Rotire. Se da un vector cu n elemente. Rotiti elementele vectorului cu o pozitie spre stanga. Prin rotire spre stanga primul element devine ultimul, al doilea devine primul etc.  \n");
            Console.WriteLine("9.Rotire k. Se da un vector cu n elemente. Rotiti elementele vectorului cu k pozitii spre stanga.  \n");
            Console.WriteLine("10.Cautare binara. Se da un vector cu n elemente sortat in ordine crescatoare. Se cere sa se determine pozitia unui element dat k. Daca elementul nu se gaseste in vector rezultatul va fi -1.  \n");
            Console.WriteLine("11.Se da un numar natural n. Se cere sa se afiseze toate numerele prime mai mici sau egale cu n (ciurul lui Eratostene).  \n");
            Console.WriteLine("12.Sortare selectie. Implementati algoritmul de sortare <Selection Sort>.  \n");
            Console.WriteLine("13.Sortare prin insertie. Implementati algoritmul de sortare <Insertion Sort>.  \n");
            Console.WriteLine("14.Interschimbati elementele unui vector in asa fel incat la final toate valorile egale cu zero sa ajunga la sfarsit. (nu se vor folosi vectori suplimentari - operatia se va realiza inplace cu un algoritm eficient - se va face o singura parcugere a vectorului).  \n");
            Console.WriteLine("15.Modificati un vector prin eliminarea elementelor care se repeta, fara a folosi un alt vector.  \n");
            Console.WriteLine("16.Se da un vector de n numere naturale. Determinati cel mai mare divizor comun al elementelor vectorului. \n");
            Console.WriteLine("17.Se da un numar n in baza 10 si un numar b. 1 < b < 17. Sa se converteasca si sa se afiseze numarul n in baza b.    \n");
            Console.WriteLine("18.Se da un polinom de grad n ai carui coeficienti sunt stocati intr-un vector. Cel mai putin semnificativ coeficient este pe pozitia zero in vector. Se cere valoarea polinomului intr-un punct x.  \n");
            Console.WriteLine("19.Se da un vector s (vectorul in care se cauta) si un vector p (vectorul care se cauta). Determinati de cate ori apare p in s. De ex. Daca s = [1,2,1,2,1,3,1,2,1] si p = [1,2,1] atunci p apare in s de 3 ori. (Problema este dificila doar daca o rezolvati cu un algoritm liniar).  \n");
            Console.WriteLine("20.Se dau doua siraguri de margele formate din margele albe si negre, notate s1, respectiv s2. Determinati numarul de suprapuneri (margea cu margea) a unui sirag peste celalalt astfel incat margelele suprapuse au aceeasi culoare. Siragurile de margele se pot roti atunci cand le suprapunem.  \n");
            Console.WriteLine("21.Se dau doi vectori. Se cere sa se determine ordinea lor lexicografica (care ar trebui sa apara primul in dictionar).  \n");
            Console.WriteLine("22.Se dau doi vectori v1 si v2. Se cere sa determine intersectia, reuniunea, si diferentele v1-v2 si v2 -v1 (implementarea operatiilor cu multimi). Elementele care se repeta vor fi scrise o singura data in rezultat.  \n");
            Console.WriteLine("23.Aceleasi cerinte ca si la problema anterioara dar de data asta elementele din v1 respectiv v2  sunt in ordine strict crescatoare.  \n");
            Console.WriteLine("24.Aceleasi cerinte ca si la problema anterioara dar de data asta elementele sunt stocate ca vectori cu valori binare (v[i] este 1 daca i face parte din multime si este 0 in caz contrar). \n");
            Console.WriteLine("25.(Interclasare) Se dau doi vector sortati crescator v1 si v2. Construiti un al treilea vector ordonat crescator format din toate elementele din  v1 si v2. Sunt permise elemente duplicate.  \n");
            Console.WriteLine("26.Se dau doua numere naturale foarte mari (cifrele unui numar foarte mare sunt stocate intr-un vector - fiecare cifra pe cate o pozitie). Se cere sa se determine suma, diferenta si produsul a doua astfel de numere.  \n");
            Console.WriteLine("27.Se da un vector si un index in vectorul respectiv. Se cere sa se determine valoarea din vector care va fi pe pozitia index dupa ce vectorul este sortat.  \n");
            Console.WriteLine("28.Quicksort. Sortati un vector folosind metoda QuickSort.  \n");
            Console.WriteLine("29.MergeSort. Sortati un vector folosind metoda MergeSort. \n");
            Console.WriteLine("30.Sortare bicriteriala. Se dau doi vectori de numere intregi E si W, unde E[i] este un numar iar W[i] este un numar care reprezinta ponderea lui E[i]. Sortati vectorii astfel incat elementele lui E sa fie in in ordine crescatoare iar pentru doua valori egale din E, cea cu pondere mai mare va fi prima.  \n");
            Console.WriteLine("31.(Element majoritate). Intr-un vector cu n elemente, un element m este element majoritate daca mai mult de n/2 din valorile vectorului sunt egale cu m (prin urmare, daca un vector are element majoritate acesta este unui singur).  Sa se determine elementul majoritate al unui vector (daca nu exista atunci se va afisa <nu exista>). (incercati sa gasiti o solutie liniara).  \n");

            Console.WriteLine("Alegeti una din problemele de mai sus: \n");

            optiune = int.Parse(Console.ReadLine());
            switch (optiune)
            {
                case 1:
                    P1();
                    break;
                case 2:
                    P2();
                    break;
                case 3:
                    P3();
                    break;
                case 4:
                    P4();
                    break;
                case 5:
                    P5();
                    break;
                case 6:
                    P6();
                    break;
                case 7:
                    P7();
                    break;
                case 8:
                    P8();
                    break;
                case 9:
                    P9();
                    break;
                case 10:
                    P10();
                    break;
                case 11:
                    P11();
                    break;
                case 12:
                    P12();
                    break;
                case 13:
                    P13();
                    break;
                case 14:
                    P14();
                    break;
                case 15:
                    P15();
                    break;
                case 16:
                    P16();
                    break;
                case 17:
                    P17();
                    break;
                case 18:
                    P18();
                    break;
                case 19:
                    P19();
                    break;
                case 20:
                    P20();
                    break;
                case 21:
                    P21();
                    break;
                case 22:
                    P22();
                    break;
                case 23:
                    P23();
                    break;
                case 24:
                    P24();
                    break;
                case 25:
                    P25();
                    break;
                case 26:
                    P26();
                    break;
                case 27:
                    P27();
                    break;
                case 28:
                    P28();
                    break;
                case 29:
                    P29();
                    break;
                case 30:
                    P30();
                    break;
                case 31:
                    P31();
                    break;

            }
        }
        /// <summary>
        /// (Element majoritate). Intr-un vector cu n elemente, un element m este element majoritate daca mai mult de n/2 din valorile vectorului sunt egale cu m 
        /// (prin urmare, daca un vector are element majoritate acesta este unui singur). 
        /// Sa se determine elementul majoritate al unui vector (daca nu exista atunci se va afisa <nu exista>). (incercati sa gasiti o solutie liniara). 
        /// </summary>
        private static void P31()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Sortare bicriteriala. Se dau doi vectori de numere intregi E si W, unde E[i] este un numar iar W[i] este un numar care reprezinta ponderea lui E[i]. Sortati vectorii astfel incat elementele lui E sa fie in in ordine crescatoare iar pentru doua valori egale din E, cea cu pondere mai mare va fi prima. 
        /// </summary>
        private static void P30()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// MergeSort. Sortati un vector folosind metoda MergeSort.
        /// </summary>
        private static void P29()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Quicksort. Sortati un vector folosind metoda QuickSort.
        /// </summary>
        private static void P28()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        ///  Se da un vector si un index in vectorul respectiv. Se cere sa se determine valoarea din vector care va fi pe pozitia index dupa ce vectorul este sortat. 
        /// </summary>
        private static void P27()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Se dau doua numere naturale foarte mari (cifrele unui numar foarte mare sunt stocate intr-un vector - fiecare cifra pe cate o pozitie). Se cere sa se determine suma, diferenta si produsul a doua astfel de numere. 
        /// </summary>
        private static void P26()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// (Interclasare) Se dau doi vector sortati crescator v1 si v2. Construiti un al treilea vector ordonat crescator format din toate elementele din  v1 si v2. Sunt permise elemente duplicate. 
        /// </summary>
        private static void P25()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Aceleasi cerinte ca si la problema anterioara dar de data asta elementele sunt stocate ca vectori cu valori binare (v[i] este 1 daca i face parte din multime si este 0 in caz contrar).
        /// </summary>
        private static void P24()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Aceleasi cerinte ca si la problema anterioara dar de data asta elementele din v1 respectiv v2  sunt in ordine strict crescatoare. 
        /// </summary>
        private static void P23()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Se dau doi vectori v1 si v2. Se cere sa determine intersectia, reuniunea, si diferentele v1-v2 si v2 -v1 (implementarea operatiilor cu multimi). Elementele care se repeta vor fi scrise o singura data in rezultat. 
        /// </summary>
        private static void P22()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Se dau doi vectori. Se cere sa se determine ordinea lor lexicografica (care ar trebui sa apara primul in dictionar). 
        /// </summary>
        private static void P21()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Se dau doua siraguri de margele formate din margele albe si negre, notate s1, respectiv s2. Determinati numarul de suprapuneri (margea cu margea) a unui sirag peste celalalt astfel incat margelele suprapuse au aceeasi culoare. Siragurile de margele se pot roti atunci cand le suprapunem. 
        /// </summary>
        private static void P20()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Se da un vector s (vectorul in care se cauta) si un vector p (vectorul care se cauta). Determinati de cate ori apare p in s. De ex. Daca s = [1,2,1,2,1,3,1,2,1] si p = [1,2,1] atunci p apare in s de 3 ori. (Problema este dificila doar daca o rezolvati cu un algoritm liniar).
        /// </summary>
        private static void P19()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Se da un polinom de grad n ai carui coeficienti sunt stocati intr-un vector. Cel mai putin semnificativ coeficient este pe pozitia zero in vector. Se cere valoarea polinomului intr-un punct x. 
        /// </summary>
        private static void P18()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Se da un numar n in baza 10 si un numar b. 1 < b < 17. Sa se converteasca si sa se afiseze numarul n in baza b.   
        /// </summary>
        private static void P17()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Se da un vector de n numere naturale. Determinati cel mai mare divizor comun al elementelor vectorului.
        /// </summary>
        private static void P16()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Modificati un vector prin eliminarea elementelor care se repeta, fara a folosi un alt vector. 
        /// </summary>
        private static void P15()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Interschimbati elementele unui vector in asa fel incat la final toate valorile egale cu zero sa ajunga la sfarsit. (nu se vor folosi vectori suplimentari - operatia se va realiza inplace cu un algoritm eficient - se va face o singura parcugere a vectorului). 
        /// </summary>
        private static void P14()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Sortare prin insertie. Implementati algoritmul de sortare <Insertion Sort>. 
        /// </summary>
        private static void P13()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Sortare selectie. Implementati algoritmul de sortare <Selection Sort>. 
        /// </summary>
        private static void P12()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Se da un numar natural n. Se cere sa se afiseze toate numerele prime mai mici sau egale cu n (ciurul lui Eratostene). 
        /// </summary>
        private static void P11()
        {
            
        }
        /// <summary>
        /// Cautare binara. Se da un vector cu n elemente sortat in ordine crescatoare. Se cere sa se determine pozitia unui element dat k. 
        /// Daca elementul nu se gaseste in vector rezultatul va fi -1. 
        /// </summary>
        private static void P10()
        {
            int n, i, sol = -1, left = 0, mid, right,k;
            Console.WriteLine("Introduceti n:");
            n = int.Parse(Console.ReadLine());
            right = n-1;
            int[] v = new int[n];
            Console.WriteLine("Introduceti elementele vectorului");
            for (i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti k:");
            k = int.Parse(Console.ReadLine());
            while(left<=right)
            {
                mid = (left + right) / 2;
                if(v[mid]==k)
                {
                    sol = mid;
                    break;
                }
                if (v[mid] > k)
                    right = mid - 1;
                if (v[mid] < k)
                    left = mid + 1;
            }
            Console.WriteLine($"elementul {k} se afla pe pozitia {sol}");
        }
        /// <summary>
        /// Rotire k. Se da un vector cu n elemente. Rotiti elementele vectorului cu k pozitii spre stanga. 
        /// </summary>
        private static void P9()
        {
            int n, i,j, k,aux;
            Console.WriteLine("Introduceti n:");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.WriteLine("Introduceti elementele vectorului");
            for (i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("introduceti k:");
            k = int.Parse(Console.ReadLine());
            for (j = 1; j <= k; j++)
            {
                aux = v[0];
                for (i = 0; i < n - 1; i++)
                    v[i] = v[i + 1];
                v[n - 1] = aux;
            }
            Console.WriteLine("Noul vector este:");
            for (i = 0; i < n; i++)
                Console.Write(v[i] + " ");
        }
        /// <summary>
        /// Rotire. Se da un vector cu n elemente. Rotiti elementele vectorului cu o pozitie spre stanga.
        /// Prin rotire spre stanga primul element devine ultimul, al doilea devine primul etc. 
        /// </summary>
        private static void P8()
        {
            int n, i, aux;
            Console.WriteLine("Introduceti n:");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.WriteLine("Introduceti elementele vectorului");
            for (i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
            aux = v[0];
            for (i = 0; i < n-1; i++)
                v[i] = v[i + 1];
            v[n - 1] = aux;
            Console.WriteLine("Noul vector este:");
            for (i = 0; i < n; i++)
                Console.Write(v[i] + " ");
        }
        /// <summary>
        /// Reverse. Se da un vector cu n elemente. Se cere sa se inverseze ordinea elementelor din vector. 
        /// Prin inversare se intelege ca primul element devine ultimul, al doilea devine penultimul etc.
        /// </summary>
        private static void P7()
        {
            int n, i,aux;
            Console.WriteLine("Introduceti n:");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.WriteLine("Introduceti elementele vectorului");
            for (i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
            for(i=0;i<n/2;i++)
            {
                aux = v[i];
                v[i] = v[n - i - 1];
                v[n - i - 1] = aux;
            }
            Console.WriteLine("Noul vector este:");
            for (i = 0; i < n; i++)
                Console.Write(v[i] + " ");
        }
        /// <summary>
        /// Se da un vector cu n elemente si o pozitie din vector k. Se cere sa se stearga din vector elementul de pe pozitia k. 
        /// Prin stergerea unui element, toate elementele din dreapta lui se muta cu o pozitie spre stanga. 
        /// </summary>
        private static void P6()
        {
            int n, i, k;
            Console.WriteLine("Introduceti n:");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.WriteLine("Introduceti elementele vectorului");
            for (i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti k:");
            k = int.Parse(Console.ReadLine());
            for(i=k;i<n-1;i++)
                v[i] = v[i + 1];
            n--;
            Console.WriteLine("Noul vector este:");
            for (i = 0; i < n; i++)
                Console.Write(v[i] + " ");
        }
        /// <summary>
        /// Se da un vector cu n elemente, o valoare e si o pozitie din vector k. Se cere sa se insereze valoarea e in vector pe pozitia k.
        /// Primul element al vectorului se considera pe pozitia zero. 
        /// </summary>
        private static void P5()
        {
            int n, i, e, k;
            Console.WriteLine("Introduceti n:");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n+1];
            Console.WriteLine("Introduceti elementele vectorului");
            for (i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti e (valoarea care trebuie inserata):");
            e = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti k (pozitia pe care se insereaza e):");
            k = int.Parse(Console.ReadLine());
            for (i = n; i > k; i--)
                v[i] = v[i - 1];
            n++;
            v[k] = e;
            Console.WriteLine("Noul vector este:");
            for(i=0;i<n;i++)
                Console.Write(v[i]+" ");
        }
        /// <summary>
        /// Deteminati printr-o singura parcurgere, cea mai mica si cea mai mare valoare dintr-un vector si de cate ori apar acestea. 
        /// </summary>
        private static void P4()
        {
            int n, i, min = int.MaxValue, max = int.MinValue,apmin=0,apmax=0;
            Console.WriteLine("Introduceti n:");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.WriteLine("Introduceti pe o singura linie, despartite prin cate un spatiu, elementele vectorului");
            string linie = Console.ReadLine();
            char[] sep = { ' ' };
            string[] tokens = linie.Split(sep, StringSplitOptions.RemoveEmptyEntries);
            for(i=0;i<n;i++)
            {
                v[i] = int.Parse(tokens[i]);
                if(v[i]<min)
                {
                    apmin = 1;
                    min = v[i];
                }
                else if (v[i] == min)
                    apmin++;
                if (v[i] > max)
                {
                    apmax = 1;
                    max = v[i];
                }
                else if (v[i] == max)
                    apmax++;
            }
            Console.WriteLine($"Minimul este {min} si apare de {apmin} ori, iar maximul este {max} si apare de {apmax} ori");
        }
        /// <summary>
        /// Sa se determine pozitiile dintr-un vector pe care apar cel mai mic si cel mai mare element al vectorului. 
        /// Pentru extra-credit realizati programul efectuand 3n/2 comparatii (in cel mai rau caz). 
        /// </summary>
        private static void P3()
        {
            int n, i, pozmin = 0, pozmax=0;
            Console.WriteLine("Introduceti n:");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.WriteLine("Introduceti pe o singura linie, despartite prin cate un spatiu, elementele vectorului");
            string linie = Console.ReadLine();
            char[] sep = { ' ' };
            string[] tokens = linie.Split(sep, StringSplitOptions.RemoveEmptyEntries);
            for (i = 1; i < n; i++)
            {
                v[i] = int.Parse(tokens[i]);
                if (v[i] > v[pozmax])
                    pozmax = i;
                if (v[i] < v[pozmin])
                    pozmin = i;
            }
            Console.WriteLine($"Minimul apare pe pozitia {pozmin}, iar maximul pe pozitia {pozmax}");

        }
        /// <summary>
        /// Se da un vector cu n elemente si o valoare k. Se cere sa se determine prima pozitie din vector pe care apare k. Daca k nu apare in vector rezultatul va fi -1. 
        /// </summary>
        private static void P2()
        {
            int n, k, i,poz=-1;
            Console.WriteLine("Introduceti n:");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.WriteLine("Introduceti pe o singura linie, despartite prin cate un spatiu, elementele vectorului");
            string linie = Console.ReadLine();
            char[] sep = { ' ' };
            string[] tokens = linie.Split(sep, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Introduceti k:");
            k = int.Parse(Console.ReadLine());
            for(i=0;i<n;i++)
            {
                v[i] = int.Parse(tokens[i]);
                if(v[i]==k)
                {
                    poz = i;
                    break;
                }
            }
            Console.WriteLine($"Pozitia pe care apare k este {poz}");
        }
        /// <summary>
        /// Calculati suma elementelor unui vector de n numere citite de la tastatura. Rezultatul se va afisa pe ecran.
        /// </summary>
        private static void P1()
        {
            int n, suma=0,i;
            Console.WriteLine("Introduceti n:");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.WriteLine("Introduceti pe o singura linie, despartite prin cate un spatiu, elementele vectorului");
            string linie = Console.ReadLine();
            char[] sep = { ' ' };
            string[] tokens = linie.Split(sep, StringSplitOptions.RemoveEmptyEntries);
            for(i=0;i<n;i++)
            {
                v[i] = int.Parse(tokens[i]);
                suma += v[i];
            }
            Console.WriteLine($"Suma vectorului este {suma}");
        }
    }
}
