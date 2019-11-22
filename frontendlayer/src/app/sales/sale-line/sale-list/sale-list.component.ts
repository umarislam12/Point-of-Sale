import { SaleService } from "./../../../shared/sale/sale.service";
import { Observable } from "rxjs/Observable";
import { ProductsService } from "src/app/shared/products/products.service";
import { Component, OnInit } from "@angular/core";
import { CustomerService } from "src/app/shared/customer/customer.service";
import { ToastrService } from "ngx-toastr";
import { Products } from "src/app/shared/products/products.model";
import { DataSource } from "@angular/cdk/collections";

// export interface Transaction {
//   productId: number;
//   productName: string;
//   unitPrice: number;
//   SaleLine: { saleLineId: number; quantity: number; totalQuantity: number };
// }

@Component({
  selector: "app-sale-list",
  templateUrl: "./sale-list.component.html",
  styleUrls: ["./sale-list.component.css"]
})
export class SaleListComponent implements OnInit {
  sampleData;
  constructor(
    public service: CustomerService,
    public Saleservice: SaleService,
    private toastr: ToastrService
  ) {}
  // columns = customer;
  // tslint:disable-next-line: no-use-before-declare

  // dataSource = new ProductsDataSource(this.productsServ);
  // displayedColumns = [
  //   "productId",
  //   "productName",
  //   "Quantity",
  //   "unitprice",
  //   "totalQuantity"
  // ];
  // transactions: Products[] = [
  //   {
  //     productId: 0,
  //     productName: "",
  //     unitPrice: 0,
  //     SaleLine: { saleLineId: 0, quantity: 0, totalQuantity: 0 }
  //   }
  // ];

  /** Gets the total cost of all transactions. */
  // getTotalCost() {
  // return this.transactions
  // .map(t => t.SaleLine.totalQuantity)
  // .reduce((acc, value) => acc + value, 0);
  // }
  // populateForm(cust: Customer) {
  //   this.service.formData = Object.assign({}, cust);
  // }
  // onDelete(id: number) {
  //   if (confirm("are you sure you want to delete this record?")) {
  //     this.service
  //       .deleteCustomer(id)
  //       .subscribe(res => this.productsServ.listTheProducts());
  //     this.toastr.warning("Deleted successfully", "item Deleted");
  //   }
  // }
  // getTotalCost() {
  //   return this.productsServ.prodList
  //     .map(t => t.unitPrice)
  //     .reduce((acc, value) => acc + value, 0);
  // }

  ngOnInit() {
    var salelist = this.Saleservice.getProducts();
    console.log(salelist);
    //   this.productsServ.getData().subscribe(sampleData => {
    //     this.sampleData = sampleData;
    //     console.log("sampleData", this.sampleData);
    // });
    //   this.dataSource.connect();
    //   console.log(this.dataSource);
    // this.productsServ.listTheProducts();
    //   }
  }
  // export class ProductsDataSource extends DataSource<any> {
  //   constructor(private productsServ: ProductsService) {
  //     super();
  //   }
  //   connect(): Observable<Products[]> {
  //     //   //   debugger;
  //     return this.productsServ.getProducts();
  //   }
  //   disconnect() {}
}
