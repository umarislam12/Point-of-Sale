export class Products {
  productId: number;
  productName: string;
  unitPrice: number;
  saleLineId: number;
  quantity: number;
  totalQuantity: number;
  //foreign key from sale
  // public int saleId { get; set; }
  //public Sale Sale { get; set; }
  //SaleLine: SaleLine;
  // productId: number;
}
