using System;
using System.Collections;

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
        /// (Element majoritate). Intr-un vector cu n elemente, un element m este element majoritate daca mai mult de n/2 din valorile vectorului 
        /// sunt egale cu m (prin urmare, daca un vector are element majoritate acesta este unui singur). 
        /// Sa se determine elementul majoritate al unui vector (daca nu exista atunci se va afisa <nu exista>). 
        /// (incercati sa gasiti o solutie liniara). 
        /// </summary>
        private static void P31()
        {
            int n, cand=-1,k=0,i,nr=0;
            Console.WriteLine("Introduceti n:");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.WriteLine("Introduceti elementele vectorului pe cate o linie:");
            for(i=0;i<n;i++)
            {
                v[i] = int.Parse(Console.ReadLine());
                if (k == 0)
                {
                    cand = v[i];
                    k = 1;
                }
                else if (v[i] == cand)
                    k++;
                else
                    k--;
            }
            for (i = 0; i < n; i++)
                if (v[i] == cand)
                    nr++;
            if(nr>n/2)
                Console.WriteLine($"Elementul majoritar este {cand}");
            else
                Console.WriteLine("Nu exista element majoritar");
        }
        /// <summary>
        /// Sortare bicriteriala. Se dau doi vectori de numere intregi E si W, unde E[i] este un numar iar W[i] este un numar care reprezinta
        /// ponderea lui E[i]. Sortati vectorii astfel incat elementele lui E sa fie in in ordine crescatoare iar pentru doua valori egale din E, 
        /// cea cu pondere mai mare va fi prima. 
        /// </summary>
        private static void P30()
        {
            int n, i,j,aux;
            Console.WriteLine("Introduceti numarul de elemente al vectorilor E si W:");
            n = int.Parse(Console.ReadLine());
            int[] E = new int[n];
            int[] frecv = new int[10000];
            Console.WriteLine($"Introduceti cele {n} elemente ale vectorului E (fiecare el. pe cate o linie):");
            for(i=0;i<n;i++)
            {
                E[i] = int.Parse(Console.ReadLine());
                frecv[E[i]]++;
            }
            int[] W = new int[n];
            Console.WriteLine($"Introduceti cele {n} elemente ale vectorului W (fiecare el. pe cate o linie):");
            for (i = 0; i < n; i++)
            {
                W[i] = int.Parse(Console.ReadLine());
            }
            for (i=0;i<n-1;i++)
            {
                if (frecv[E[i]]==2)
                {
                    for (j=i+1;j<n;j++)
                        if(j==E[i])
                        {
                            if (W[i]<W[j])
                            {
                                aux = E[i];
                                E[i] = E[j];
                                E[j] = aux;
                            }
                        }
                }
            }
            for (i=0;i<n-1;i++)
                for(j=i+1;j<n;j++)
                    if (E[i]>E[j])
                    {
                        aux = E[i];
                        E[i] = E[j];
                        E[j] = aux;
                    }
            Console.WriteLine("Vectorul sortat dupa criteriile din cerinta este urmatorul: ");
            for(i=0;i<n;i++)
                Console.Write(E[i]+" ");
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
        ///  Se da un vector si un index in vectorul respectiv. Se cere sa se determine valoarea din vector care va fi pe pozitia index 
        ///  dupa ce vectorul este sortat. 
        /// </summary>
        private static void P27()
        {
            int n, index,i,j,aux;
            Console.WriteLine("Introduceti n:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti indexul:");
            index = int.Parse(Console.ReadLine());
            int[] v = new int[n + 1];
            Console.WriteLine("Introduceti elementele vectorului pe cate o linie:");
            for (i = 1; i <= n; i++)
                v[i] = int.Parse(Console.ReadLine());
            for(i=1;i<n;i++)
                for(j=i+1;j<=n;j++)
                    if(v[j]<v[i])
                    {
                        aux = v[i];
                        v[i] = v[j];
                        v[j] = aux;
                    }
            Console.WriteLine("Vectorul sortat este:");
            for(i=1;i<=n;i++)
                Console.Write(v[i]+" ");
            Console.WriteLine($"\nElementul de pe pozitia {index} este {v[index]}");
        }
        /// <summary>
        /// Se dau doua numere naturale foarte mari (cifrele unui numar foarte mare sunt stocate intr-un vector - fiecare cifra pe cate o pozitie). 
        /// Se cere sa se determine suma, diferenta si produsul a doua astfel de numere. 
        /// </summary>
        private static void P26()
        {
            int cif1, cif2, n=0, m=0, i, item_nr1, item_nr2, suma, carry, produs, poz=0, j, sum, num, s,gasit=0,aux,lungime;
            int[] nr1 = new int[10001];
            int[] nr2 = new int[10001];
            Console.WriteLine("Cate cifre are primul numar?");
            cif1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti cifrele primului numar pe linii separate:");
            int[] s1 = new int[cif1];
            for (i = 0; i < cif1; i++)
            {
                s1[i] = int.Parse(Console.ReadLine());
                if (s1[i] > 9 || s1[i] < 0)
                {
                    Console.WriteLine("Trebuie sa introduceti doar cifre naturale!");
                    Environment.Exit(0);
                }
            }
            Console.WriteLine("Cate cifre are al doilea numar?");
            cif2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti cifrele celui de-al doilea numar pe linii separate:");
            int[] s2 = new int[cif2];
            for (i = 0; i < cif2; i++)
            {
                s2[i] = int.Parse(Console.ReadLine());
                if (s2[i] > 9 || s2[i] < 0)
                {
                    Console.WriteLine("Trebuie sa introduceti doar cifre naturale!");
                    Environment.Exit(0);
                }
            }

            //verificare care numar este mai mare, iar apoi stocare in nr1 (numarul cel mai mare) si in nr2 (numarul cel mai mic)
            if (cif1>cif2)
            {
                for (i = 0; i < cif1; i++)
                    nr1[i] = s1[i];
                for (j = 0; j < cif2; j++)
                    nr2[j] = s2[j];
                n = cif1;
                m = cif2;
                gasit = 1;
            }
            else if (cif2>cif1)
            {
                for (i = 0; i < cif2; i++)
                    nr1[i] = s2[i];
                for (j = 0; j < cif1; j++)
                    nr2[j] = s1[j];
                n = cif2;
                m = cif1;
                gasit = 2;
            }
            else if (cif1==cif2)
            {
                gasit = 0; //numerele (s1 si s2) sunt egale
                for(i=0;i<cif1;i++)
                {
                    if(s1[i]>s2[i])
                    {
                        gasit = 1; //primul nr (s1) este mai mare
                        break;
                    }
                    else if (s2[i]>s1[i])
                    {
                        gasit = 2; //al doilea nr (s2) este mai mare
                    }
                }
                if (gasit == 0 || gasit==1)
                {
                    for (i = 0; i < cif1; i++)
                    {
                        nr1[i] = s1[i];
                        nr2[i] = s2[i];
                    }
                }
                if(gasit==2)
                {
                    for(i=0;i<cif1;i++)
                    {
                        nr1[i] = s2[i];
                        nr2[i] = s1[i];
                    }
                }
                n = m = cif1;
            }
            
            //inversez ordinea elementelor din nr1 si nr2 (primul devine ultimul, al doilea devine penultimul etc.)
            for(i=0;i<=(n-1)/2;i++)
            {
                aux = nr1[i];
                nr1[i] = nr1[n - 1 - i];
                nr1[n - 1 - i] = aux;
            }
            for (i = 0; i <= (m - 1) / 2; i++)
            {
                aux = nr2[i];
                nr2[i] = nr2[m - 1 - i];
                nr2[m - 1 - i] = aux;
            }

            lungime = n; //se stie ca n reprezinta numarul maxim de cifre

            //pentru suma:
            int[] rezultat_s = new int[lungime+1];
            for(i=0;i<lungime;i++)
            {
                item_nr1 = (i < n) ? nr1[i] : 0;
                item_nr2 = (i < m) ? nr2[i] : 0;

                suma = rezultat_s[i] + item_nr1 + item_nr2;
                rezultat_s[i] = suma % 10;

                carry = suma / 10;
                rezultat_s[i + 1] += carry;
            }
            Console.WriteLine("Suma este: ");
            for(i=lungime;i>=0;i--)
                Console.Write(rezultat_s[i]+" ");
            Console.WriteLine();

            //pentru diferenta:
            int[] rezultat_d = new int[lungime];
            for (i = 0; i < lungime; i++)
            {
                item_nr1 = (i < n) ? nr1[i] : 0;
                item_nr2 = (i < m) ? nr2[i] : 0;

                if (item_nr1 > item_nr2)
                    rezultat_d[i] = item_nr1 - item_nr2;
                else if(item_nr2>item_nr1)
                {
                    rezultat_d[i] = (item_nr1 + 10) - item_nr2;
                    if(i<lungime-1)
                    nr1[i + 1]--;
                }
            }
            Console.WriteLine("Diferenta este: " );
            if(gasit==2) //daca, initial al doilea numar a fost cel mai mare, atunci diferenta numerelor este negativa si scriu un "-" in fata rezultatului
                Console.Write("- ");
            for (i = lungime-1; i >= 0; i--)
                Console.Write(rezultat_d[i] + " ");
            Console.WriteLine();

            //pentru produs:
            int[] rezultat_p = new int[n+m];
            s = 0;
            for(i=0;i<n;i++)
            {   
                carry = 0;
                poz = s;
                for(j=0;j<m;j++)
                {
                    produs = nr1[i] * nr2[j];
                    sum = produs + rezultat_p[poz] + carry;
                    num = sum % 10;
                    carry = sum / 10;
                    rezultat_p[poz] = num;
                    poz++;
                }
                rezultat_p[poz] = rezultat_p[poz] + carry;
                s++;
            }
            Console.WriteLine("Produsul este: ");
            for(i=n+m-1;i>=0;i--)
                Console.Write(rezultat_p[i]+" ");

        }
        /// <summary>
        /// (Interclasare) Se dau doi vector sortati crescator v1 si v2. Construiti un al treilea vector ordonat crescator format
        /// din toate elementele din  v1 si v2. Sunt permise elemente duplicate. 
        /// </summary>
        private static void P25()
        {
            int n, m, i, j,nr=0;
            Console.WriteLine("Introduceti n:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti m:");
            m = int.Parse(Console.ReadLine());
            int[] v1 = new int[n+1];
            int[] v2 = new int[m+1];
            int[] v3 = new int[101];
            Console.WriteLine("Introduceti elementele primului vector, pe cate o linie:");
            for (i = 1; i <= n; i++)
                v1[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti elementele celui de-al doilea vector, pe cate o linie:");
            for (j = 1; j <= m; j++)
                v2[j] = int.Parse(Console.ReadLine());
            i = 1;
            j = 1;
            while (i <= n && j <= m)
                if (v1[i] < v2[j])
                    v3[++nr] = v1[i++];
                else
                    v3[++nr] = v2[j++];
            while (i <= n)
                v3[++nr] = v1[i++];
            while (j <= m)
                v3[++nr] = v2[j++];
            Console.WriteLine("Elementele interclasate sunt:");
            for(i=1;i<=n+m;i++)
                Console.Write(v3[i]+" ");
        }
        /// <summary>
        /// Aceleasi cerinte ca si la problema anterioara dar de data asta elementele sunt stocate ca vectori cu valori binare 
        /// (v[i] este 1 daca i face parte din multime si este 0 in caz contrar).
        /// </summary>
        private static void P24()
        {
            int n, m, i;
            Console.WriteLine("Cate elemente are primul vector?");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Cate elemente are al doilea vector?");
            m = int.Parse(Console.ReadLine());
            int[] v1 = new int[n];
            int[] v2 = new int[m];
            int[] v3 = new int[n + m];
            Console.WriteLine("Introduceti pe cate o linie elementele primului vector:");
            for (i = 0; i < n; i++)
                v1[i] = int.Parse(Console.ReadLine());
            Array.Sort(v1); //in caz ca nu sunt introduse in ordine crescatoare
            Console.WriteLine("Introduceti pe cate o linie elementele celui de-al doilea vector:");
            for (i = 0; i < m; i++)
                v2[i] = int.Parse(Console.ReadLine());
            Array.Sort(v2); //in caz ca nu sunt introduse in ordine crescatoare
            Console.WriteLine("Vectorii sortati crescator sunt:");
            for (i = 0; i < n; i++)
                Console.Write(v1[i] + " ");
            Console.WriteLine();
            for (i = 0; i < m; i++)
                Console.Write(v2[i] + " ");
            Console.WriteLine();
            Intersectia_v2(v1, v2, n, m);
            Console.WriteLine();
            Reuniunea_v2(v1, v2, n, m);
            Console.WriteLine();
            Diferenta12_v2(v1, v2, n, m);
            Console.WriteLine();
            Diferenta21_v2(v2, v1, n, m);
        }

        private static void Diferenta21_v2(int[] v2, int[] v1, int n, int m)
        {
            int i, j, poz = 0, gasit;
            int[] v3 = new int[n + m];
            for (j = 0; j < m; j++)
            {
                gasit = 0;
                for (i = 0; i < m; i++)
                    if (v2[j] == v1[i])
                    {
                        gasit = 1;
                        break;
                    }
                if (gasit == 0)
                {
                    v3[poz] = 1;
                    poz++;
                }
                else
                {
                    v3[poz] = 0;
                    poz++;
                }
            }
            Console.WriteLine("Diferenta vectorilor v2 si v1 este urmatoarea:");
            for (i = 0; i < poz; i++)
                Console.Write(v3[i] + " ");
        }

        private static void Diferenta12_v2(int[] v1, int[] v2, int n, int m)
        {
            int i, j, poz = 0, gasit;
            int[] v3 = new int[n + m];
            for (i = 0; i < n; i++)
            {
                gasit = 0;
                for (j = 0; j < m; j++)
                    if (v1[i] == v2[j])
                    {
                        gasit = 1;
                        break;
                    }
                if (gasit == 0)
                {
                    v3[poz] = 1;
                    poz++;
                }
                else
                {
                    v3[poz] = 0;
                    poz++;
                }
            }
            Console.WriteLine("Diferenta vectorilor v1 si v2 este urmatoarea:");
            for (i = 0; i < poz; i++)
                Console.Write(v3[i] + " ");
        }

        private static void Reuniunea_v2(int[] v1, int[] v2, int n, int m)
        {
            int i, j, poz = 0, gasit;
            int[] v3 = new int[n + m];
            for (i = 0; i < n; i++)
            {
                v3[poz] = 1;
                poz++;
            }
            for (i = 0; i < m; i++)
            {
                gasit = 0;
                for (j = 0; j < n; j++)
                    if (v2[i] == v1[j])
                    {
                        gasit = 1;
                        v3[poz] = 1;
                        poz++;
                        break;
                    }
                if (gasit == 0)
                {
                    v3[poz] = 1;
                    poz++;
                }
            }
            Console.WriteLine("Reuniunea vectorilor este urmatoarea:");
            for (i = 0; i < poz; i++)
                Console.Write(v3[i]+ " ");
        }

        private static void Intersectia_v2(int[] v1, int[] v2, int n, int m)
        {
            int i, j, poz = 0, gasit;
            int[] v3 = new int[n + m];
            for (i = 0; i < n; i++)
            {
                gasit = 0;
                for (j = 0; j < m; j++)
                    if (v1[i] == v2[j])
                    {
                        gasit = 1;
                        break;
                    }
                if (gasit == 1)
                {
                    v3[poz] = 1;
                    poz++;
                }
                else
                {
                    v3[poz] = 0;
                    poz++;
                }
            }
            Console.WriteLine("Intersectia vectorilor este urmatoarea:");
            for (i = 0; i < poz; i++)
                Console.Write(v3[i]+" ");
        }

        /// <summary>
        /// Aceleasi cerinte ca si la problema anterioara dar de data asta elementele din v1 respectiv v2 sunt in ordine strict crescatoare. 
        /// </summary>
        private static void P23()
        {
            int n, m, i;
            Console.WriteLine("Cate elemente are primul vector?");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Cate elemente are al doilea vector?");
            m = int.Parse(Console.ReadLine());
            int[] v1 = new int[n];
            int[] v2 = new int[m];
            int[] v3 = new int[n + m];
            Console.WriteLine("Introduceti pe cate o linie elementele primului vector:");
            for (i = 0; i < n; i++)
                v1[i] = int.Parse(Console.ReadLine());
            Array.Sort(v1); //in caz ca nu sunt introduse in ordine crescatoare
            Console.WriteLine("Introduceti pe cate o linie elementele celui de-al doilea vector:");
            for (i = 0; i < m; i++)
                v2[i] = int.Parse(Console.ReadLine());
            Array.Sort(v2); //in caz ca nu sunt introduse in ordine crescatoare
            Console.WriteLine("Vectorii sortati crescator sunt:");
            for (i = 0; i < n; i++)
                Console.Write(v1[i]+" ");
            Console.WriteLine();
            for (i = 0; i < m; i++)
                Console.Write(v2[i] + " ");
            Console.WriteLine();
            Intersectia(v1, v2, n, m);
            Console.WriteLine();
            Reuniunea(v1, v2, n, m);
            Console.WriteLine();
            Diferenta12(v1, v2, n, m);
            Console.WriteLine();
            Diferenta21(v2, v1, n, m);
        }
        /// <summary>
        /// Se dau doi vectori v1 si v2. Se cere sa determine intersectia, reuniunea, si diferentele v1-v2 si v2 -v1 
        /// (implementarea operatiilor cu multimi). Elementele care se repeta vor fi scrise o singura data in rezultat. 
        /// </summary>
        private static void P22()
        {
            int n, m,i;
            Console.WriteLine("Cate elemente are primul vector?");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Cate elemente are al doilea vector?");
            m = int.Parse(Console.ReadLine());
            int[] v1 = new int[n];
            int[] v2 = new int[m];
            int[] v3 = new int[n + m];
            Console.WriteLine("Introduceti pe cate o linie elementele primului vector:");
            for (i = 0; i < n; i++)
                v1[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti pe cate o linie elementele celui de-al doilea vector:");
            for (i = 0; i < m; i++)
                v2[i] = int.Parse(Console.ReadLine());
            Intersectia(v1, v2, n, m);
            Console.WriteLine();
            Reuniunea(v1, v2, n, m);
            Console.WriteLine();
            Diferenta12(v1, v2, n, m);
            Console.WriteLine();
            Diferenta21(v2, v1, n, m);
        }

        private static void Diferenta21(int[] v2, int[] v1, int n, int m)
        {
            int i, j, poz = 0, gasit;
            int[] v3 = new int[n + m];
            for (j = 0; j < m; j++)
            {
                gasit = 0;
                for (i = 0; i < m; i++)
                    if (v2[j] == v1[i])
                    {
                        gasit = 1;
                        break;
                    }
                if (gasit == 0)
                {
                    v3[poz] = v2[j];
                    poz++;
                }
            }
            Console.WriteLine("Diferenta vectorilor v2 si v1 este urmatoarea:");
            for (i = 0; i < poz; i++)
                Console.Write(v3[i] + " ");
        }

        private static void Diferenta12(int[] v1, int[] v2, int n, int m)
        {
            int i, j, poz = 0, gasit;
            int[] v3 = new int[n + m];
            for (i=0;i<n;i++)
            {
                gasit = 0;
                for (j = 0; j < m; j++)
                    if (v1[i] == v2[j])
                    {
                        gasit = 1;
                        break;
                    }
                if (gasit==0)
                {
                    v3[poz] = v1[i];
                    poz++;
                }
            }
            Console.WriteLine("Diferenta vectorilor v1 si v2 este urmatoarea:");
            for (i = 0; i < poz; i++)
                Console.Write(v3[i] + " ");
        }

        private static void Reuniunea(int[] v1, int[] v2, int n, int m)
        {
            int i, j, poz = 0, gasit;
            int[] v3 = new int[n + m];
            for (i=0;i<n;i++)
            {
                v3[poz] = v1[i];
                poz++;
            }
            for(i=0;i<m;i++)
            {
                gasit = 0;
                for(j=0;j<n;j++)
                    if(v2[i]==v1[j])
                    {
                        gasit = 1;
                        break;
                    }
                if(gasit==0)
                {
                    v3[poz] = v2[i];
                    poz++;
                }
            }
            Console.WriteLine("Reuniunea vectorilor este urmatoarea:");
            for(i=0;i<poz;i++)
                Console.Write(v3[i]+" ");
        }

        private static void Intersectia(int[] v1, int[] v2, int n, int m)
        {
            int i, j, poz=0,gasit;
            int[] v3 = new int[n + m];
            for(i=0;i<n;i++)
            {
                gasit = 0;
                for (j = 0; j <m; j++)
                    if (v1[i] == v2[j])
                    {
                        gasit = 1;
                        break;
                    }
                if (gasit==1)
                {
                    v3[poz] = v1[i];
                    poz++;
                }     
            }
            Console.WriteLine("Intersectia vectorilor este urmatoarea:");
            for(i=0;i<poz;i++)
                Console.Write(v3[i]+" ");
        }

        /// <summary>
        /// Se dau doi vectori. Se cere sa se determine ordinea lor lexicografica (care ar trebui sa apara primul in dictionar). 
        /// </summary>
        private static void P21()
        {
            string cuv1, cuv2;
            int lungimea_minima=0,i,ok=0;
            Console.WriteLine("Care este primul cuvant?");
            cuv1 = Console.ReadLine();
            Console.WriteLine("Care este al doilea cuvant?");
            cuv2 = Console.ReadLine();
            if (cuv1==cuv2)
                Console.WriteLine("Cuvintele sunt la fel");
            else if(cuv1[0]<cuv2[0])
                    Console.WriteLine($"{cuv1} apare primul in dictionar");
                else if(cuv1[0]>cuv2[0])
                    Console.WriteLine($"{cuv2} apare primul in dictionar");
            else
            {
                if (cuv1.Length <= cuv2.Length)
                       lungimea_minima = cuv1.Length;
                else if (cuv1.Length > cuv2.Length)
                       lungimea_minima = cuv2.Length;
                for (i = 1; i < lungimea_minima; i++)
                {
                    if (cuv1[i] < cuv2[i])
                    {
                        Console.WriteLine($"{cuv1} apare primul in dictionar");
                        ok = 1;
                        break;
                    }
                    else if (cuv1[i] > cuv2[i])
                    {
                        Console.WriteLine($"{cuv2} apare primul in dictionar");
                        ok = 1;
                        break;
                    }
                }
                if(ok==0) //inseamna ca cuvantul de lungime minima este prefixul celuilalt (ex. ana si anamaria), asadar cuv. de lungime minima apare primul in dictionar
                    if(cuv1.Length==lungimea_minima)
                        Console.WriteLine($"{cuv1} apare primul in dictionar");
                    else if (cuv2.Length == lungimea_minima)
                        Console.WriteLine($"{cuv2} apare primul in dictionar");

            }

        }
        /// <summary>
        /// Se dau doua siraguri de margele formate din margele albe si negre, notate s1, respectiv s2. 
        /// Determinati numarul de suprapuneri (margea cu margea) a unui sirag peste celalalt astfel incat margelele suprapuse au aceeasi culoare. 
        /// Siragurile de margele se pot roti atunci cand le suprapunem. 
        /// </summary>
        private static void P20()
        {
            int n,i,suprapuneri=0;
            Console.WriteLine("Cate margele au siragurile?");
            n = int.Parse(Console.ReadLine());
            int[] s1 = new int[n];
            int[] s2 = new int[n];
            Console.WriteLine("Introduceti, pe cate o linie, margelele primului sirag (1 pt. margea alba, 0 pt. margea neagra):");
            for(i=0;i<n;i++)
            {
                s1[i] = int.Parse(Console.ReadLine());
                if (s1[i] != 0 && s1[i] != 1)
                {
                    Console.Write("Numarul nu este valid");
                    break;
                }
            }
            Console.WriteLine("Introduceti, pe cate o linie, margelele celui de-al doilea sirag (1 pt. margea alba, 0 pt. margea neagra):");
            for (i = 0; i < n; i++)
            {
                s2[i] = int.Parse(Console.ReadLine());
                if (s2[i] != 0 && s2[i] != 1)
                {
                    Console.Write("Numarul nu este valid");
                    break;
                }
            }
            for (i = 0; i < n; i++)
                if (s1[i] == s2[i])
                    suprapuneri++;
            Console.WriteLine($"Nr. de suprapuneri este {suprapuneri}");

        }
        /// <summary>
        /// Se da un vector s (vectorul in care se cauta) si un vector p (vectorul care se cauta). Determinati de cate ori apare p in s.
        /// De ex. Daca s = [1,2,1,2,1,3,1,2,1] si p = [1,2,1] atunci p apare in s de 3 ori.
        /// (Problema este dificila doar daca o rezolvati cu un algoritm liniar).
        /// </summary>
        private static void P19()
        {
            int n, m,i,ok,pas,k,aparitii=0;
            Console.WriteLine("Introduceti n (nr. de elemente ale vectorului s):");
            n = int.Parse(Console.ReadLine());
            int[] s = new int[n];
            Console.WriteLine("Introduceti elementele vectorului s (cate unul pe o linie:");
            for (i = 0; i < n; i++)
                s[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti m (nr. de elemente ale vectorului p):");
            m = int.Parse(Console.ReadLine());
            int[] p = new int[m];
            Console.WriteLine("Introduceti elementele vectorului p (cate unul pe o linie):");
            for (i = 0; i < m; i++)
                p[i] = int.Parse(Console.ReadLine());
            for(i=0;i<=n-m;i++)
            {
                ok = 1;
                pas = 0;
                k = 0;
                while (ok!=0 && pas<m)
                {
                    if (s[i+k] != p[pas])
                    {
                        ok = 0;
                        break;
                    }
                    else
                    {
                        pas++;
                        k++;
                    }
                }
                if (ok == 1)
                    aparitii++;
            }
            Console.WriteLine($"vectorul p apare in vectorul s de {aparitii} ori");
        }
        /// <summary>
        /// Se da un polinom de grad n ai carui coeficienti sunt stocati intr-un vector. Cel mai putin semnificativ coeficient este
        /// pe pozitia zero in vector. Se cere valoarea polinomului intr-un punct x. 
        /// </summary>
        private static void P18()
        {
            int n,i,nr,x;
            double val=0;
            Console.WriteLine("Introduceti n:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti x:");
            x = int.Parse(Console.ReadLine());
            int[] coef = new int[n];
            Console.WriteLine("Introduceti coeficientii pe o singura linie, despariti printr-un spatiu:");
            string linie = Console.ReadLine();
            char[] seps = { ' ' };
            string[] token = linie.Split(seps, StringSplitOptions.RemoveEmptyEntries);
            for(i=0;i<=n;i++)
            {
                nr = int.Parse(token[i]);
                val = val + nr * Math.Pow(x, i);
            }
            Console.WriteLine($"Valoarea polinomului in punctul {x} este {val}");
    
        }
        /// <summary>
        /// Se da un numar n in baza 10 si un numar b. 1 < b < 17. Sa se converteasca si sa se afiseze numarul n in baza b.   
        /// </summary>
        private static void P17()
        {
            int n, b,rest,copie_n;
            Stack baza_b= new Stack();
            Console.WriteLine("Introduceti n:");
            n = int.Parse(Console.ReadLine());
            copie_n = n;
            Console.WriteLine("Introduceti b:");
            b = int.Parse(Console.ReadLine());
            while (copie_n!=0)
            {
                rest = copie_n % b;
                if (rest == 10)
                    baza_b.Push('A');
                else if (rest == 11)
                    baza_b.Push('B');
                else if (rest == 12)
                    baza_b.Push('C');
                else if (rest == 13)
                    baza_b.Push('D');
                else if (rest == 14)
                    baza_b.Push('E');
                else if (rest == 15)
                    baza_b.Push('F');
                else
                    baza_b.Push(rest);
                copie_n = copie_n / b;
            }
            Console.WriteLine($"Numarul {n} in baza {b} este:");
            foreach(var nr in baza_b)
                Console.Write(nr);

        }
        /// <summary>
        /// Se da un vector de n numere naturale. Determinati cel mai mare divizor comun al elementelor vectorului.
        /// </summary>
        private static void P16()
        {
            int n, i,div=-1;
            Console.WriteLine("introduceti n:");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.WriteLine("introduceti, pe cate o linie, elementele vectorului:");
            for (i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
            for(i=0;i<n-1 && div!=1;i++)
            {
                div = cmmdc(v[i], v[i + 1]);
            }
            Console.WriteLine($"Cmmdc al vectorului este {div}");
        }

        private static int cmmdc(int v1, int v2)
        {
            int r;
            while  (v2!=0)
            {
                r = v1 % v2;
                v1 = v2;
                v2 = r;
            }
            return v1;
        }

        /// <summary>
        /// Modificati un vector prin eliminarea elementelor care se repeta, fara a folosi un alt vector. 
        /// </summary>
        private static void P15()
        {
            int n, i,j,k;
            Console.WriteLine("introduceti n:");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.WriteLine("introduceti, pe cate o linie, elementele vectorului:");
            for (i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
            for(i=0;i<n-1;i++)
                for(j=i+1;j<n;j++)
                {
                    if (v[i] == v[j])
                    {
                        for (k = j; k < n - 1; k++)
                            v[k] = v[k + 1];
                        n--;
                        j--;
                    }
                    
                }
            Console.WriteLine("vectorul modificat este:");
            for (i = 0; i < n; i++)
                Console.Write(v[i] + " ");
        }
        /// <summary>
        /// Interschimbati elementele unui vector in asa fel incat la final toate valorile egale cu zero sa ajunga la sfarsit.
        /// (nu se vor folosi vectori suplimentari - operatia se va realiza inplace cu un algoritm eficient - se va face o singura parcugere
        /// a vectorului). 
        /// </summary>
        private static void P14()
        {
            int n, i, ultim;
            Console.WriteLine("introduceti n:");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.WriteLine("introduceti, pe cate o linie, elementele vectorului:");
            for (i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
            ultim = n-1;
            for(i=0;i<ultim;i++)
            {
                if(v[i]==0)
                {
                    v[i] = v[ultim];
                    v[ultim] = 0;
                    ultim--;
                    i--;
                }
            }
            Console.WriteLine("vectorul reordonat este:");
            for (i = 0; i < n; i++)
                Console.Write(v[i] + " ");
        }
        /// <summary>
        /// Sortare prin insertie. Implementati algoritmul de sortare <Insertion Sort>. 
        /// </summary>
        private static void P13()
        {
            int n, i, k, aux;
            Console.WriteLine("introduceti n:");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.WriteLine("introduceti, pe cate o linie, elementele vectorului:");
            for (i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
            for(i=1;i<n;i++)
                for(k=i;k>0 && v[k]<v[k-1];k--)
                {
                    aux = v[k];
                    v[k] = v[k - 1];
                    v[k - 1] = aux;
                }
            Console.WriteLine("vectorul ordonat crescator este:");
            for (i = 0; i < n; i++)
                Console.Write(v[i] + " ");
        }
        /// <summary>
        /// Sortare selectie. Implementati algoritmul de sortare <Selection Sort>. 
        /// </summary>
        private static void P12()
        {
            int n, i, j, k,aux;
            Console.WriteLine("introduceti n:");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.WriteLine("introduceti, pe cate o linie, elementele vectorului:");
            for (i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
            for(i=0;i<n;i++)
            {
                k = i;
                for (j = i + 1; j < n; j++)
                    if (v[j] < v[k])
                        k = j;
                aux = v[i];
                v[i] = v[k];
                v[k] = aux;
            }
            Console.WriteLine("vectorul ordonat crescator este:");
            for(i=0;i<n;i++)
                Console.Write(v[i]+" ");
        }
        /// <summary>
        /// Se da un numar natural n. Se cere sa se afiseze toate numerele prime mai mici sau egale cu n (ciurul lui Eratostene). 
        /// </summary>
        private static void P11()
        {
            int n, i, j;
            Console.WriteLine("introduceti n:");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[100001];
            v[1] = 1;
            //v[x]=1 daca x NU este prim si v[x]=0 daca x este prim
            for (i = 2; i * i <= n; i++)
                if (v[i] == 0)
                    for (j = 2; j <= n / 2; j++)
                        v[i * j] = 1;
            Console.WriteLine("numerele prime mai mici decat {0} sunt: ",n);
            for(i=1;i<=n;i++)
                if(v[i]==0)
                    Console.Write(i+" ");
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
