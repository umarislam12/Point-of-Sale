import { Component, OnInit } from "@angular/core";
//import { NgForm } from "@angular/forms";
import { FormControl, FormGroup } from "@angular/forms";
import { CustomerService } from "src/app/shared/customer/customer.service";

@Component({
  selector: "app-sale",
  templateUrl: "./sale.component.html",
  styleUrls: ["./sale.component.css"]
})
export class SaleComponent implements OnInit {
  customers;
  constructor(public service: CustomerService) {}

  ngOnInit() {
    this.service.getCustomers().subscribe(res => {
      this.customers = res;
      console.log("customers", this.customers);
    });
  }
  customer = new FormControl();
}
