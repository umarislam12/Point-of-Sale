import { Component, OnInit } from "@angular/core";

import { ToastrService } from "ngx-toastr";
import { NgForm } from "@angular/forms";
import { SaleService } from "src/app/shared/sale/sale.service";
// import { ProductService } from "src/app/shared/product/product.service";

@Component({
  selector: "app-sale-line",
  templateUrl: "./sale-line.component.html",
  styleUrls: ["./sale-line.component.css"]
})
export class SaleLineComponent implements OnInit {
  prods;
  total;
  constructor(public service: SaleService, private toastr: ToastrService) {}
  // title: "directives";
  // directivess: ["D1", "D2", "D3"];
  ngOnInit() {
    this.service.getData().subscribe(prods => {
      this.prods = prods;
      console.log("prods", this.prods);
    });

    this.resetForm();
  }
  log(x) {
    console.log(x);
  }
  resetForm(form?: NgForm) {
    if (form != null) form.resetForm();
    else {
      this.service.formData = {
        saleId: 0,
        saleDate: "",
        saleNo: 0,
        saleLine: {
          saleLineId: 0,
          quantity: 0,

          totalQuantity: 0
        }

        // productId: 0
      };
    }
  }
  onSubmit(form: NgForm) {
    if (form.value.id == null) this.insertRecord(form);
    else {
      this.updateRecord(form);
    }
  }
  insertRecord(form: NgForm) {
    this.service.postsaleline(form.value).subscribe(res => {
      this.toastr.success("inserted successfully", "product inserted");
      this.resetForm(form);
      this.service.listsalelines();
    });
  }
  updateRecord(form: NgForm) {
    this.service.putProducts(form.value).subscribe(res => {
      this.toastr.info("updated successfully", "product updated");
      this.resetForm(form);
      this.service.listsalelines();
    });
  }
}
