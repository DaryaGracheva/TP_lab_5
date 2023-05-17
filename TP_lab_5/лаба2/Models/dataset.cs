using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace лаба2.Models
{
    [DisplayName("Оформить посылку")]
    public class dataset
    {
        public string? id { get; set; }

        [DisplayName("Дата")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? data { get; set; }

        [DisplayName("Откуда")]
        [DataType(DataType.MultilineText)]
        public string? adress_sender { get; set; }

        [DisplayName("Куда")]
        [DataType(DataType.MultilineText)]
        public string? adress_recipient { get; set; }

        [DisplayName("Вес посылки")]
        public string? weight { get; set; }

        [DisplayName("Ценность посылки")]
        public string? price { get; set; }

        [DisplayName("Способ доставки")]
        public bool delivery_method { get; set; }

    }

    public enum delivery_method
    {
        regular,
        expedited,
        by_courier

    }
}
