using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FusionZoho.ZohoAPI.Models
{
    public class CreateSalesOrder
    {
        public long customer_id { get; set; }
        public string salesorder_number { get; set; }
        public string date { get; set; }
        public string shipment_date { get; set; }
        public List<CustomField> custom_fields { get; set; }
        public string reference_number { get; set; }
        public List<LineItem> line_items { get; set; }
        public string notes { get; set; }
        public string terms { get; set; }
        public string discount { get; set; }
        public bool is_discount_before_tax { get; set; }
        public string discount_type { get; set; }
        public int shipping_charge { get; set; }
        public string delivery_method { get; set; }
        public int adjustment { get; set; }
        public long pricebook_id { get; set; }
        public long salesperson_id { get; set; }
        public string adjustment_description { get; set; }
        public bool is_inclusive_tax { get; set; }
        public int exchange_rate { get; set; }
        public long template_id { get; set; }
        public List<Document> documents { get; set; }
        public long billing_address_id { get; set; }
        public long shipping_address_id { get; set; }
        public string place_of_supply { get; set; }
        public string gst_treatment { get; set; }
        public string gst_no { get; set; }


    }

    public class CustomField
    {
        public int custom_field_id { get; set; }
        public int index { get; set; }
        public string label { get; set; }
        public string value { get; set; }
    }

    public class Document
    {
        public bool can_send_in_mail { get; set; }
        public string file_name { get; set; }
        public string file_type { get; set; }
        public string file_size_formatted { get; set; }
        public int attachment_order { get; set; }
        public long document_id { get; set; }
        public int file_size { get; set; }
    }

    public class LineItem
    {
        public long item_id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int rate { get; set; }
        public int quantity { get; set; }
        public string unit { get; set; }
        public long tax_id { get; set; }
        public string tds_tax_id { get; set; }
        public string tax_name { get; set; }
        public string tax_type { get; set; }
        public int tax_percentage { get; set; }
        public int item_total { get; set; }
        public long warehouse_id { get; set; }
        public int hsn_or_sac { get; set; }
        public int sat_item_key_code { get; set; }
        public string unitkey_code { get; set; }
    }

}
