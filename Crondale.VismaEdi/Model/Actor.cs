﻿using Crondale.VismaEdi.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crondale.VismaEdi.Model
{
    [EdiElement(Priority=10)]
    public class Actor : EdiModel
    {
        public String ActNo { get; set; }
        public String Nm { get; set; }
        public String Ad1 { get; set; }
        public String Ad2 { get; set; }
        public String Ad3 { get; set; }
        public String Ad4 { get; set; }
        public String PNo { get; set; }
        public String PArea { get; set; }
        public String Ctry { get; set; }
        public String Lang { get; set; }
        public String Shrt { get; set; }
        public String MailAd { get; set; }
        public String Phone { get; set; }
        public String PrivPh { get; set; }
        public String MobPh { get; set; }
        public String Pers { get; set; }
        public String Fax { get; set; }
        public String CustNo { get; set; }
        public String NwCustNo { get; set; }
        public String SupNo { get; set; }
        public String NwSupNo { get; set; }
        public String EmpNo { get; set; }
        public String NwEmpNo { get; set; }
        public String Title { get; set; }
        public String LiaAct { get; set; }
        public String Usr { get; set; }
        public String NwUsr { get; set; }
        public String Seller { get; set; }
        public String Buyer { get; set; }
        public String Rsp { get; set; }
        public String Att { get; set; }
        public String R1 { get; set; }
        public String R2 { get; set; }
        public String R3 { get; set; }
        public String R4 { get; set; }
        public String R5 { get; set; }
        public String R6 { get; set; }
        public String CrLmt { get; set; }
        public String CrSusp { get; set; }
        public String CrEval { get; set; }
        public String CustAcNo { get; set; }
        public String SupAcNo { get; set; }
        public String AgAcNo { get; set; }
        public String CustMaMt { get; set; }
        public String SupMaMt { get; set; }
        public String CAcSet { get; set; }
        public String SAcSet { get; set; }
        public String CVatNo { get; set; }
        public String SVatNo { get; set; }
        public String ExVat { get; set; }
        public String ExSpc { get; set; }
        public String DelToAct { get; set; }
        public String DelFrAct { get; set; }
        public String CStc { get; set; }
        public String SStc { get; set; }
        public String DelPri { get; set; }
        public String CDelMt { get; set; }
        public String SDelMt { get; set; }
        public String CDelTrm { get; set; }
        public String SDelTrm { get; set; }
        public String Cur { get; set; }
        public String CustPrGr { get; set; }
        public String EmpPrGr { get; set; }
        public String CustTotD { get; set; }
        public String SupTotD { get; set; }
        public String InvoCust { get; set; }
        public String FactNo { get; set; }
        public String CPmtTrm { get; set; }
        public String SPmtTrm { get; set; }
        public String CPmtMt { get; set; }
        public String SPmtMt { get; set; }
        public String BGiro { get; set; }
        public String PGiro { get; set; }
        public String DebFrDt { get; set; }
        public String DebToDt { get; set; }
        public String MaxRems { get; set; }
        public String LstRemDt { get; set; }
        public String LstRemNo { get; set; }
        public String IntRt { get; set; }
        public String RmtPri { get; set; }
        public String RmtSup { get; set; }
        public String SwftCd { get; set; }
        public String SwftAd1 { get; set; }
        public String SwftAd2 { get; set; }
        public String SwftAd3 { get; set; }
        public String SwftAd4 { get; set; }
        public String OurCNo { get; set; }
        public String InfCat { get; set; }
        public String Trade { get; set; }
        public String Distr { get; set; }
        public String BsNo { get; set; }
        public String NoOfEmp { get; set; }
        public String Turn { get; set; }
        public String Gr { get; set; }
        public String Gr2 { get; set; }
        public String Gr3 { get; set; }
        public String Gr4 { get; set; }
        public String Gr5 { get; set; }
        public String Gr6 { get; set; }
        public String Inf { get; set; }
        public String Inf2 { get; set; }
        public String Inf3 { get; set; }
        public String Inf4 { get; set; }
        public String Inf5 { get; set; }
        public String Inf6 { get; set; }
        public String FrDt { get; set; }
        public String ToDt { get; set; }
        public String SrcNo { get; set; }
        public String NoteNm { get; set; }
        public String SAgAcNo { get; set; }
        public String CreDt { get; set; }
        public String CreUsr { get; set; }
        public String Branch { get; set; }
        public String DirDeb { get; set; }
        public String MaxDebAm { get; set; }
        public String CustPrG2 { get; set; }
        public String PrSup { get; set; }
        public String SPrAdd { get; set; }
        public String CustPref { get; set; }
        public String SupPref { get; set; }
        public String Gr7 { get; set; }
        public String Gr8 { get; set; }
        public String Gr9 { get; set; }
        public String Gr10 { get; set; }
        public String Gr11 { get; set; }
        public String Gr12 { get; set; }
        public String Inf7 { get; set; }
        public String Inf8 { get; set; }
        public String YrRef { get; set; }
        public String Fax2 { get; set; }
        public String EUTaxNo { get; set; }
        public String AdmTm { get; set; }
        public String DelTm { get; set; }
        public String TanspTm { get; set; }
        public String DocSMt { get; set; }
        public String DelIntv { get; set; }
        public String LstDelDt { get; set; }
        public String MainAct { get; set; }
        public String MaxDueP { get; set; }
        public String MaxDueDy { get; set; }
        public String AcDocSMt { get; set; }
        public String SOLink { get; set; }
        public String CryptK { get; set; }
        public String ActPro { get; set; }
        public String NwCNo { get; set; }
        public String NwSNo { get; set; }
        public String PictFNm { get; set; }
        public String TspDy { get; set; }
        public String LstSuit { get; set; }
        public String ExtID { get; set; }
        public String ChExt { get; set; }
        public String IntAd1 { get; set; }
        public String IntAd2 { get; set; }
        public String OldCNo { get; set; }
        public String OldSNo { get; set; }
        public String EANLocCd { get; set; }
        public String OlAcNo { get; set; }
        public String ClReAcNo { get; set; }
        public String ClBaAcNo { get; set; }
        public String CustPrG3 { get; set; }
        public String TspAgrNo { get; set; }
        public String TonRt { get; set; }
        public String R7 { get; set; }
        public String R8 { get; set; }
        public String R9 { get; set; }
        public String R10 { get; set; }
        public String R11 { get; set; }
        public String R12 { get; set; }
        public String GiroChSm { get; set; }
        public String BankCon { get; set; }
        public String ViPNo { get; set; }
        public String ViPArea { get; set; }
        public String RemPrDt { get; set; }
        public String IntGr { get; set; }
        public String CNtDy { get; set; }
        public String ePsw { get; set; }
        public String eProc { get; set; }
        public String SmsProv { get; set; }
        public String ProdTm { get; set; }
        public String TmZn { get; set; }
        public String FCNo { get; set; }
        public String Cl3AcNo { get; set; }
        public String NrmTDisc { get; set; }
        public String TSGrNo { get; set; }
        public String FlGr { get; set; }
        public String AttAmLmt { get; set; }
        public String AgrChBal { get; set; }
        public String ShpActNo { get; set; }
        public String BPartNo { get; set; }
        public String EftSep { get; set; }
        public String ExtExpGr { get; set; }
        public String EFT1 { get; set; }
        public String EFT2 { get; set; }
        public String EFT3 { get; set; }
        public String EFT4 { get; set; }
        public String FormId { get; set; }
        public String Fee { get; set; }
        public String Cur2 { get; set; }
        public String ChTmms { get; set; }
        public String CustPre2 { get; set; }
        public String EftFrmTp { get; set; }
        public String CardAddP { get; set; }
        public String PerID { get; set; }
        public String IntFee { get; set; }

    }
}