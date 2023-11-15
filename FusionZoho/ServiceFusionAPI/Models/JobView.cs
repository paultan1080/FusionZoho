using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FusionZoho.ServiceFusionAPI.Models
{
   

        public class JobView
        {
        public int id { get; set; }
        public string number { get; set; }
        public string check_number { get; set; }
        public string priority { get; set; }
        public string description { get; set; }
        public string tech_notes { get; set; }
        public string completion_notes { get; set; }
        public string payment_status { get; set; }
        public double taxes_fees_total { get; set; }
        public double drive_labor_total { get; set; }
        public double billable_expenses_total { get; set; }
        public double total { get; set; }
        public double payments_deposits_total { get; set; }
        public double due_total { get; set; }
        public double cost_total { get; set; }
        public int duration { get; set; }
        public string time_frame_promised_start { get; set; }
        public string time_frame_promised_end { get; set; }
        public string start_date { get; set; }
        public string end_date { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public DateTime? closed_at { get; set; }
        public int customer_id { get; set; }
        public string customer_name { get; set; }
        public string parent_customer { get; set; }
        public string status { get; set; }
        public object sub_status { get; set; }
        public string contact_first_name { get; set; }
        public string contact_last_name { get; set; }
        public string street_1 { get; set; }
        public string street_2 { get; set; }
        public string city { get; set; }
        public string state_prov { get; set; }
        public string postal_code { get; set; }
        public string location_name { get; set; }
        public bool is_gated { get; set; }
        public string gate_instructions { get; set; }
        public string category { get; set; }
        public string source { get; set; }
        public string payment_type { get; set; }
        public string customer_payment_terms { get; set; }
        public object project { get; set; }
        public object phase { get; set; }
        public string po_number { get; set; }
        public string contract { get; set; }
        public string note_to_customer { get; set; }
        public string called_in_by { get; set; }
        public bool is_requires_follow_up { get; set; }

        public List<Agent> agents { get; set; }
        public List<CustomField> custom_fields { get; set; }
        public List<Picture> pictures { get; set; }
        public List<Document> documents { get; set; }
        public List<Equipment> equipment { get; set; }
        public List<TechsAssigned> techs_assigned { get; set; }
        public List<Task> tasks { get; set; }
        public List<Note> notes { get; set; }
        public List<Product> products { get; set; }
        public List<Service> services { get; set; }
        public List<OtherCharge> other_charges { get; set; }
        public List<LaborCharge> labor_charges { get; set; }
        public List<Expense> expenses { get; set; }
        public List<Payment> payments { get; set; }
        public List<Invoice> invoices { get; set; }
        public List<Signature> signatures { get; set; }
        public List<PrintableWorkOrder> printable_work_order { get; set; }
        public List<Visit> visits { get; set; }
        public List<string> _expandable { get; set; }

    }
    public class Agent
        {
            public string id { get; set; }
            public string first_name { get; set; }
            public string last_name { get; set; }
        }

        public class CustomField
        {
            public string name { get; set; }
            public object value { get; set; }
            public string type { get; set; }
            public string group { get; set; }
            public DateTime created_at { get; set; }
            public DateTime? updated_at { get; set; }
            public bool is_required { get; set; }
        }

        public class Document
        {
            public string name { get; set; }
            public string file_location { get; set; }
            public string doc_type { get; set; }
            public string comment { get; set; }
            public string sort { get; set; }
            public string is_private { get; set; }
            public string created_at { get; set; }
            public string updated_at { get; set; }
            public string customer_doc_id { get; set; }
        }

        public class Equipment
        {
            public int id { get; set; }
            public string type { get; set; }
            public string make { get; set; }
            public string model { get; set; }
            public string sku { get; set; }
            public string serial_number { get; set; }
            public string location { get; set; }
            public string notes { get; set; }
            public string extended_warranty_provider { get; set; }
            public bool is_extended_warranty { get; set; }
            public string extended_warranty_date { get; set; }
            public string warranty_date { get; set; }
            public DateTime? install_date { get; set; }
            public DateTime created_at { get; set; }
            public DateTime? updated_at { get; set; }
            public int customer_id { get; set; }
            public string customer { get; set; }
            public string customer_location { get; set; }
            public List<CustomField> custom_fields { get; set; }
        }

        public class Expense
        {
            public string purchased_from { get; set; }
            public string notes { get; set; }
            public string amount { get; set; }
            public string is_billable { get; set; }
            public string date { get; set; }
            public string created_at { get; set; }
            public string updated_at { get; set; }
            public string user { get; set; }
            public string category { get; set; }
            public string qbo_class_id { get; set; }
            public string qbd_class_id { get; set; }
        }

        public class Invoice
        {
            public Int64 id { get; set; }
            public int number { get; set; }
            public string currency { get; set; }
            public string po_number { get; set; }
            public string terms { get; set; }
            public string customer_message { get; set; }
            public string notes { get; set; }
            public string pay_online_url { get; set; }
            public int? qbo_invoice_no { get; set; }
            public string qbo_sync_token { get; set; }
            public DateTime? qbo_synced_date { get; set; }
            public int? qbo_id { get; set; }
            public int? qbd_id { get; set; }
            public double total { get; set; }
            public bool is_paid { get; set; }
            public DateTime? date { get; set; }
            public DateTime? mail_send_date { get; set; }
            public DateTime? created_at { get; set; }
            public DateTime? updated_at { get; set; }
            public string customer { get; set; }
            public string customer_contact { get; set; }
            public string payment_terms { get; set; }
            public int? bill_to_customer_id { get; set; }
            public int? bill_to_customer_location_id { get; set; }
            public int? bill_to_customer_contact_id { get; set; }
            public int? bill_to_email_id { get; set; }
            public int? bill_to_phone_id { get; set; }
        }

        public class LaborCharge
        {
            public double drive_time { get; set; }
            public double drive_time_rate { get; set; }
            public double drive_time_cost { get; set; }
            public string drive_time_start { get; set; }
            public string drive_time_end { get; set; }
            public bool is_drive_time_billed { get; set; }
            public double labor_time { get; set; }
            public double labor_time_rate { get; set; }
            public double labor_time_cost { get; set; }
            public string labor_time_start { get; set; }
            public string labor_time_end { get; set; }
            public DateTime labor_date { get; set; }
            public bool is_labor_time_billed { get; set; }
            public double total { get; set; }
            public DateTime created_at { get; set; }
            public DateTime? updated_at { get; set; }
            public bool is_status_generated { get; set; }
            public string user { get; set; }
            public int? visit_id { get; set; }
            public int? qbo_class_id { get; set; }
            public int? qbd_class_id { get; set; }
        }

        public class Note
        {
            public string notes { get; set; }
            public string created_at { get; set; }
            public string updated_at { get; set; }
        }

        public class OtherCharge
        {
            public string name { get; set; }
            public string rate { get; set; }
            public string total { get; set; }
            public string charge_index { get; set; }
            public string parent_index { get; set; }
            public string is_percentage { get; set; }
            public string is_discount { get; set; }
            public string created_at { get; set; }
            public string updated_at { get; set; }
            public string other_charge { get; set; }
            public string applies_to { get; set; }
            public string service_list_id { get; set; }
            public string other_charge_id { get; set; }
            public string pattern_row_id { get; set; }
            public string qbo_class_id { get; set; }
            public string qbd_class_id { get; set; }
        }

        public class Payment
        {
            public string transaction_type { get; set; }
            public string transaction_token { get; set; }
            public string transaction_id { get; set; }
            public string payment_transaction_id { get; set; }
            public string original_transaction_id { get; set; }
            public string apply_to { get; set; }
            public string amount { get; set; }
            public string memo { get; set; }
            public string authorization_code { get; set; }
            public string bill_to_street_address { get; set; }
            public string bill_to_postal_code { get; set; }
            public string bill_to_country { get; set; }
            public string reference_number { get; set; }
            public string is_resync_qbo { get; set; }
            public string created_at { get; set; }
            public string updated_at { get; set; }
            public string received_on { get; set; }
            public string qbo_synced_date { get; set; }
            public string qbo_id { get; set; }
            public string qbd_id { get; set; }
            public string customer { get; set; }
            public string type { get; set; }
            public string invoice_id { get; set; }
            public string gateway_id { get; set; }
            public string receipt_id { get; set; }
        }

        public class Picture
        {
            public string name { get; set; }
            public string file_location { get; set; }
            public string doc_type { get; set; }
            public string comment { get; set; }
            public Int32 sort { get; set; }
            public bool is_private { get; set; }
            public string created_at { get; set; }
            public string updated_at { get; set; }
            public string customer_doc_id { get; set; }
        }

        public class PrintableWorkOrder
        {
            public string name { get; set; }
            public string url { get; set; }
        }

        public class Product
        {
            public string name { get; set; }
            public string description { get; set; }
            public int multiplier { get; set; }
            public double rate { get; set; }
            public double total { get; set; }
            public double cost { get; set; }
            public double actual_cost { get; set; }
            public int item_index { get; set; }
            public int parent_index { get; set; }
            public DateTime created_at { get; set; }
            public DateTime updated_at { get; set; }
            public Boolean is_show_rate_items { get; set; }
            public double? tax { get; set; }
            public string product { get; set; }
            public int? product_list_id { get; set; }
            public int? warehouse_id { get; set; }
            public int? pattern_row_id { get; set; }
            public int? qbo_class_id { get; set; }
            public int? qbd_class_id { get; set; }
        }

       

        public class Service
        {
            public string name { get; set; }
            public string description { get; set; }
            public int multiplier { get; set; }
            public double rate { get; set; }
            public double total { get; set; }
            public double cost { get; set; }
            public double actual_cost { get; set; }
            public int item_index { get; set; }
            public int parent_index { get; set; }
            public DateTime created_at { get; set; }
            public DateTime updated_at { get; set; }
            public bool is_show_rate_items { get; set; }
            public double? tax { get; set; }
            public string service { get; set; }
            public int service_list_id { get; set; }
            public int service_rate_id { get; set; }
            public int? pattern_row_id { get; set; }
            public int? qbo_class_id { get; set; }
            public int? qbd_class_id { get; set; }
        }

        public class Signature
        {
            public string type { get; set; }
            public string file_name { get; set; }
            public DateTime created_at { get; set; }
            public DateTime updated_at { get; set; }
        }

        public class Task
        {
            public string type { get; set; }
            public string description { get; set; }
            public DateTime? start_time { get; set; }
            public DateTime? start_date { get; set; }
            public DateTime? end_date { get; set; }
            public bool is_completed { get; set; }
            public DateTime? created_at { get; set; }
            public DateTime? updated_at { get; set; }
        }

        public class TechsAssigned
        {
            public Int32 id { get; set; }
            public string first_name { get; set; }
            public string last_name { get; set; }
        }

        public class Visit
        {
            public string notes_for_techs { get; set; }
            public string time_frame_promised_start { get; set; }
            public string time_frame_promised_end { get; set; }
            public string duration { get; set; }
            public bool is_text_notified { get; set; }
            public bool is_voice_notified { get; set; }
            public DateTime start_date { get; set; }
            public DateTime status { get; set; }
            public List<TechsAssigned> techs_assigned { get; set; }
        }


    }
