using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elasticsearch
{
    class Policy
    {
        private long? Owner_Client_FK { get; set; }
        private long? PO_Policy_Master_FK { get; set; }
        private long? PO_Term_Master_FK { get; set; }
        private long? PO_Transaction_FK { get; set; }
        private String Submission_Date { get; set; }
        private long? PR_Product_FK { get; set; }
        private String PR_Product_Code { get; set; }
        private String PR_Product_Name { get; set; }
        private String Last_Org_Name { get; set; }
        private String First_Name { get; set; }
        private String Middle_Name { get; set; }
        private long? Issue_State_FK { get; set; }
        private String Issue_State_Code { get; set; }
        private String Postal_Code { get; set; }
        private String App_Status { get; set; }
        private String App_Sub_Status { get; set; }
        private long Agency_Account_FK { get; set; }
        private String Agency_Name { get; set; }
        private long Sub_Agent_Client_FK { get; set; }
        private String Sub_Agent_Name { get; set; }
        private String App_Type { get; set; }
        private String PR_Tran_Type_Code { get; set; }
        private String App_Policy_No { get; set; }
        private String Trans_Effective_From { get; set; }
        private String Transaction_Status { get; set; }
        private Double Net_Premium { get; set; }
        private long Insured_Mobile { get; set; }
        private String Insured_Email { get; set; }
        private String IS_Archived { get; set; }
        private String Audit_Inserted_User { get; set; }
        private String Audit_Inserted_Date { get; set; }
        private String Audit_Updated_User { get; set; }
        private String Audit_Updated_Date { get; set; }
    }
}
