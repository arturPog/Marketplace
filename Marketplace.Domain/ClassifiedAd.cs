using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketplace.Domain
{
    public class ClassifiedAd
    {
        public Guid Id { get; set; }
        public ClassifiedAd(Guid id) 
        {
            if (id == default) 
            {
                throw new ArgumentNullException("tożsamość musi być określona",nameof(id));
            }
            Id = id;

        }
        public void SetTitle(string title) => _title = title;
        public void UpdateText(string text) => _text = text;
        public void UpdatePrice(decimal price) => _price = price;

        private Guid _ownerId;
        private string _title;
        private string _text;
        private decimal _price;
    }
}
