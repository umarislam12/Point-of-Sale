import { CustomerService } from "./../../shared/customer/customer.service";
import { Component, OnInit } from "@angular/core";
import { NgForm } from "@angular/forms";
import { ToastrService } from "ngx-toastr";
import { Sale } from "src/app/shared/sale/sale.model";
import { from } from "rxjs";

@Component({
  selector: "app-customer",
  templateUrl: "./customer.component.html",

  styleUrls: ["./customer.component.css"]
})
export class CustomerComponent implements OnInit {
  constructor(public service: CustomerService, private toastr: ToastrService) {}
  // title: "directives";
  // directivess: ["D1", "D2", "D3"];
  ngOnInit() {
    this.resetForm();
  }
  log(x) {
    console.log(x);
  }
  resetForm(form?: NgForm) {
    if (form != null) form.resetForm();
    else {
      this.service.formData = {
        id: null,
        name: "",
        gender: "",
        dateOfBirth: "",
        isActive: true
        //saleId: 0
      };
    }
  }
  // onSubmit(form: NgForm) {
  //   console.log(form);
  //   if (form.value.id == null) this.insertRecord(form);
  //   else this.updateRecord(form);

  //   // if (form.value.id == null) this.insertRecord(form);
  //   // else {
  //   //   this.updateRecord(form);
  //   // }
  // }
  //experiment

  onSubmit(form: NgForm) {
    // console.log(form);
    // this.service.postCustomer(form.value).subscribe(
    //   res => {
    //     this.resetForm(form);
    //   },
    //   err => {
    //     console.log(err);
    //   }
    // );
    console.log("checking", form.value);
    if (form.value.id == null) this.insertRecord(form);
    else {
      this.updateRecord(form);
    }
  }
  insertRecord(form: NgForm) {
    // tslint:disable-next-line: no-debugger

    this.service.postCustomer(form.value).subscribe(res => {
      this.toastr.success("inserted successfully", "customer inserted");
      this.resetForm(form);
      this.service.listTheCustomers();
    });
  }
  updateRecord(form: NgForm) {
    this.service.putCustomer(form.value).subscribe(res => {
      this.toastr.info("updated successfully", "customer updated");
      this.resetForm(form);
      this.service.listTheCustomers();
    });
  }
}
