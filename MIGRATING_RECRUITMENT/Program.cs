using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MIGRATING_RECRUITMENT.NEW_DB;
using MIGRATING_RECRUITMENT.OLD_DB;

namespace MIGRATING_RECRUITMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            RecruitEntities olddb = new RecruitEntities();
            RECRUITMENTEntities newdb = new RECRUITMENTEntities();

            List<NEWADH> newadhoslist = olddb.NEWADH.ToList();

            //foreach (var sin in newadhoslist)
            //{
            //    PAY_DETAIL pd = new PAY_DETAIL();
            //    pd.BAISC = sin.BASIC;
            //    pd.FILENO = sin.FILENO;
            //    pd.HRA = sin.HRA;
            //    pd.INCR = sin.INCR;
            //    pd.PAYBILL_ID = sin.paybill_id;
            //    pd.PAYBILL_NO = sin.paybill_no;

            //    newdb.PAY_DETAIL.Add(pd);
            //    try
            //    {
            //        newdb.SaveChanges();
            //    }
            //    catch (Exception ex)
            //    {

            //    }

            //}

            //foreach (var din in newadhoslist)
            //{
            //    PERSONAL_INFO gd = new PERSONAL_INFO();
            //    gd.ADDRESS1 = din.ADDRESS1;
            //    gd.ADDRESS2 = din.ADDRESS2;
            //    gd.ADDRESS3 = din.ADDRESS3;
            //    gd.ADDRESS4 = din.ADDRESS4;
            //    gd.BLDGRP = din.BLDGRP;
            //    gd.CITY = din.CITY;
            //    gd.DOB = din.DOB;
            //    gd.EMAIL_ID = din.email_id;
            //    gd.FATHER = din.FATHER;
            //    gd.FILENO = din.FILENO;
            //    gd.NAME = din.NAME;
            //    gd.PENSIONER = din.Pensioner;
            //    gd.PHONE = din.PHONE;
            //    gd.QUALIFICATION = din.Qualification;
            //    gd.RH = din.RH;
            //    gd.R_ADDR1 = din.R_ADDR1;
            //    gd.R_ADDR2 = din.R_ADDR2;
            //    gd.R_ADDR3 = din.R_ADDR3;
            //    gd.R_ADDR4 = din.R_ADDR4;
            //    gd.R_CITY = din.R_CITY;
            //    gd.R_PHONE = din.R_PHONE;
            //    gd.R_PIN = din.R_PIN;
            //    gd.SCSTOS = din.SCSTOS;
            //    gd.SEX = din.SEX;

            //    newdb.PERSONAL_INFO.Add(gd);
            //    try
            //    {
            //        newdb.SaveChanges();
            //    }
            //    catch (Exception ex)
            //    {

            //    }



            //}

            //foreach (var tin in newadhoslist)
            //{
            //    PROJECT_INFO sd = new PROJECT_INFO();
            //    sd.COO = tin.COO;
            //    sd.COOR = tin.COOR;
            //    sd.FILENO = tin.FILENO;
            //    sd.PROJECTNO = tin.PROJECTNO;
            //    sd.PTYPE = tin.PTYPE;
            //    sd.SPON = tin.SPON;
            //    sd.TITLE = tin.TITLE;

            //    newdb.PROJECT_INFO.Add(sd);
            //    try
            //    {
            //        newdb.SaveChanges();

            //    }
            //    catch (Exception ex)
            //    {

            //    }
            //}
            //foreach (var pin in newadhoslist)
            //{
            //    EMP_DETAIL dd = new EMP_DETAIL();
            //    dd.DEPARTMENT = pin.DEPARTMENT;
            //    dd.DEPT = pin.DEPT;
            //    dd.DESIG = pin.DESIG;
            //    dd.DESIGN = pin.DESIGN;
            //    dd.DRLF = pin.DRLF;
            //    dd.DTAP = pin.DTAP;
            //    dd.EXTN = pin.EXTN;
            //    dd.EXTN_DATE = pin.extn_date;
            //    dd.FILENO = pin.FILENO;
            //    dd.OLD_FILENO = pin.OLD_FILENO;
            //    dd.STAT = pin.STAT;

            //    newdb.EMP_DETAIL.Add(dd);
            //    try
            //    {
            //        newdb.SaveChanges();
            //    }
            //    catch (Exception ex)
            //    {

            //    }
            //}

            //foreach (var fin in newadhoslist)
            //{
            //    MS_PHD ss = new MS_PHD();
            //    ss.COURSE = fin.COURSE;
            //    ss.FILENO = fin.FILENO;
            //    ss.SEMESTER = fin.SEMESTER;
            //    ss.YR = fin.YR;

            //    newdb.MS_PHD.Add(ss);
            //    try
            //    {
            //        newdb.SaveChanges();
            //    }
            //    catch (Exception ex)
            //    {

            //    }
            //}

            //foreach (var bin in newadhoslist)
            //{
            //    META aa = new META();
            //    aa.DT_CHG = bin.DT_CHG;
            //    aa.DT_INP = bin.DT_INP;
            //    aa.FILENO = bin.FILENO;

            //    newdb.META.Add(aa);
            //    try
            //    {
            //        newdb.SaveChanges();
            //    }
            //    catch (Exception ex)
            //    {

            //    }
            //}

            //foreach (var cin in newadhoslist)
            //{
            //    ADDITIONAL_INFO jj = new ADDITIONAL_INFO();
            //    jj.DINC = cin.DINC;
            //    jj.FILENO = cin.FILENO;
            //    jj.LDINC = cin.LDINC;
            //    jj.MEDICAL = cin.MEDICAL;
            //    jj.MONTH = cin.MONTH;
            //    jj.PCODE = cin.PCODE;
            //    jj.PFLAG = cin.PFLAG;
            //    jj.PROVISIONAL = cin.PROVISIONAL;
            //    jj.RATE = cin.RATE;
            //    jj.REM = cin.REM;

            //    newdb.ADDITIONAL_INFO.Add(jj);
            //    try
            //    {
            //        newdb.SaveChanges();
            //    }
            //    catch (Exception ex)
            //    {

            //    }
            //}
             foreach (var hin in newadhoslist)
            {
                RECRUIT_TYPE fin = new RECRUIT_TYPE();
                fin.FILENO = hin.FILENO;
                fin.TYPE = 1;

                newdb.RECRUIT_TYPE.Add(fin);
                try
                {
                    newdb.SaveChanges();
                } 
                catch (Exception ex)
                {

                }
            }

        }
    }
}
