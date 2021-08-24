using System;
using System.Collections.Generic;

namespace GUIMayor
{
    public class Mayor
    {
        public string name { get; set; }
        public string start { get; set; }
        public string end { get; set; }

        public Mayor(string name, string start, string end)
        {
            this.name = name; this.start = start; this.end = end;
        }

        public static List<Mayor> GetMayors()
        {
            List<Mayor> mayors = new List<Mayor>();

            mayors.Add(new Mayor("William Lyon Mackenzie", "1834 (March 27)", "1835"));
            mayors.Add(new Mayor("Robert Baldwin Sullivan", "1835 (January 15)", "1836"));
            mayors.Add(new Mayor("Thomas David Morrison", "1836", "1837"));
            mayors.Add(new Mayor("George Gurnett", "1837", "1838"));
            mayors.Add(new Mayor("John Powell", "1838", "1841"));
            mayors.Add(new Mayor("George Monro", "1841", "1842"));
            mayors.Add(new Mayor("Henry Sherwood", "1842", "1845"));
            mayors.Add(new Mayor("William H. Boulton", "1845", "1848"));
            mayors.Add(new Mayor("George Gurnett", "1848", "1851"));
            mayors.Add(new Mayor("John George Bowes", "1851", "1854"));
            mayors.Add(new Mayor("Joshua George Beard", "1854", "1855"));
            mayors.Add(new Mayor("George William Allan", "1855", "1856"));
            mayors.Add(new Mayor("John Beverley Robinson", "1856", "1857"));
            mayors.Add(new Mayor("John Hutchison", "1857", "1858 (resigned)"));
            mayors.Add(new Mayor("William H. Boulton", "1858", "1858 (resigned November 8)"));
            mayors.Add(new Mayor("David Breakenridge Read", "1858 (November 11)", "1858 (December 31)"));
            mayors.Add(new Mayor("Francis Henry Medcalf", "1864", "1867"));
            mayors.Add(new Mayor("John George Bowes", "1861", "1864"));
            mayors.Add(new Mayor("(Sir) Adam Wilson", "1859", "1861"));
            mayors.Add(new Mayor("James Edward Smith", "1867", "1869"));
            mayors.Add(new Mayor("Samuel Bickerton Harman", "1869", "1871"));
            mayors.Add(new Mayor("Joseph Sheard", "1871", "1873"));
            mayors.Add(new Mayor("Alexander Manning", "1873", "1874"));
            mayors.Add(new Mayor("Francis Henry Medcalf", "1874", "1875"));
            mayors.Add(new Mayor("Angus Morrison", "1876", "1878"));
            mayors.Add(new Mayor("James Beaty", "1879", "1880"));
            mayors.Add(new Mayor("William Barclay McMurrich", "1881", "1882"));
            mayors.Add(new Mayor("Arthur Radcliffe Boswell", "1883", "1884"));
            mayors.Add(new Mayor("Alexander Manning", "1885", "1885"));
            mayors.Add(new Mayor("William Holmes Howland", "1886", "1887"));
            mayors.Add(new Mayor("Edward Frederick Clarke", "1888", "1891"));
            mayors.Add(new Mayor("Robert John Fleming", "1892", "1893"));
            mayors.Add(new Mayor("Warring Kennedy", "1894", "1895"));
            mayors.Add(new Mayor("Robert John Fleming", "1896", "1897 (resigned August 5)"));
            mayors.Add(new Mayor("John Shaw", "1897 (August 6)", "1899"));
            mayors.Add(new Mayor("Ernest A. Macdonald", "1900", "1900"));
            mayors.Add(new Mayor("Oliver Aiken Howland", "1901", "1902"));
            mayors.Add(new Mayor("Thomas Urquhart", "1903", "1905"));
            mayors.Add(new Mayor("Emerson Coatsworth", "1906", "1907"));
            mayors.Add(new Mayor("Joseph Oliver", "1908", "1909"));
            mayors.Add(new Mayor("George Reginald Geary", "1910", "1912 (resigned October 21)"));
            mayors.Add(new Mayor("Horatio C. Hocken", "1912", "1914"));
            mayors.Add(new Mayor("Thomas Langton Church", "1915", "1921"));
            mayors.Add(new Mayor("Charles A. Maguire", "1922", "1923"));
            mayors.Add(new Mayor("W. W. Hiltz", "1924", "1924"));
            mayors.Add(new Mayor("Thomas Foster", "1925", "1927"));
            mayors.Add(new Mayor("Sam McBride", "1928", "1929"));
            mayors.Add(new Mayor("Bert Sterling Wemp", "1930", "1930"));
            mayors.Add(new Mayor("William James Stewart", "1931", "1934"));
            mayors.Add(new Mayor("James Simpson", "1935", "1935"));
            mayors.Add(new Mayor("Sam McBride", "1936", "1936 (died November 10)"));
            mayors.Add(new Mayor("William D. Robbins", "1936 (November 18)", "1937"));
            mayors.Add(new Mayor("Ralph C. Day", "1938", "1940"));
            mayors.Add(new Mayor("Frederick J. Conboy", "1941", "1944"));
            mayors.Add(new Mayor("Robert Hood Saunders", "1945", "1948 (resigned February 23)"));
            mayors.Add(new Mayor("Hiram E. McCallum", "1948", "1951"));
            mayors.Add(new Mayor("Allan Lamport", "1952 (January 1)", "Alderman for Ward 2 (1937)"));
            mayors.Add(new Mayor("Leslie Howard Saunders", "1954 (June 28)", "1954 (November 30)"));
            mayors.Add(new Mayor("Nathan Phillips", "1955 (January 1)", "1962 (November 30)"));
            mayors.Add(new Mayor("Donald Dean Summerville", "1963 (January 1)", "November 19, 1963 (died in office) [7]"));
            mayors.Add(new Mayor("Philip Givens", "1963 (November 19)", "1966 (December 31)"));
            mayors.Add(new Mayor("William Dennison", "1967 (January 1)", "1972 (December 31)"));
            mayors.Add(new Mayor("David Crombie", "1973 (January 1)", "1978 (August 31)"));
            mayors.Add(new Mayor("Fred Beavis", "1978 (September 1)", "1978 (November 30)"));
            mayors.Add(new Mayor("John Sewell", "1978 (December 1)", "1980 (November 30)"));
            mayors.Add(new Mayor("Art Eggleton", "1980 (December 1)", "1991 (November 30)"));
            mayors.Add(new Mayor("June Rowlands", "1991 (December 1)", "1994 (November 30)"));
            mayors.Add(new Mayor("Barbara Hall", "1994 (December 1)", "1997 (December 31)"));
            mayors.Add(new Mayor("Mel Lastman", "1998 (January 1)", "2003 (November 30)"));
            mayors.Add(new Mayor("David Miller", "2003 (December 1)", "2010 (November 30)"));
            mayors.Add(new Mayor("Rob Ford", "2010 (December 1)", "2014 (November 30)"));
            mayors.Add(new Mayor("John Tory", "2014 (December 1)", "Present"));
            return mayors;
        }
    }
}
