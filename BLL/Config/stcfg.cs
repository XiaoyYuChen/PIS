using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Config
{
    public class stcfg
    {
        private bool useFMl;

        public bool UseFMl
        {
            get { return useFMl; }
            set { useFMl = value; }
        }
        private bool useFirstPA;

        public bool UseFirstPA
        {
            get { return useFirstPA; }
            set { useFirstPA = value; }
        }
        private bool useFirstIN;

        public bool UseFirstIN
        {
            get { return useFirstIN; }
            set { useFirstIN = value; }
        }
        private bool useFirstIPC;

        public bool UseFirstIPC
        {
            get { return useFirstIPC; }
            set { useFirstIPC = value; }
        }
        private bool useFirstCPC;

        public bool UseFirstCPC
        {
            get { return useFirstCPC; }
            set { useFirstCPC = value; }
        }
        private bool useCPY;

        public bool UseCPY
        {
            get { return useCPY; }
            set { useCPY = value; }
        }
        private bool addSum;

        public bool AddSum
        {
            get { return addSum; }
            set { addSum = value; }
        }

        private int startYear;

        public int StartYear
        {
            get { return startYear; }
            set { startYear = value; }
        }
        private int endYear;

        public int EndYear
        {
            get { return endYear; }
            set { endYear = value; }
        }
        private bool istype1 = false;

        public bool isType1 { get; set; }
    }
}
