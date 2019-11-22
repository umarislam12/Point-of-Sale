import { Customer } from "./../../shared/customer/customer.model";
import { CustomerService } from "./../../shared/customer/customer.service";
import { Component, OnInit } from "@angular/core";
import { ToastrService } from "ngx-toastr";

@Component({
  selector: "app-customer-list",
  templateUrl: "./customer-list.component.html",
  styleUrls: ["./customer-list.component.css"]
})
export class CustomerListComponent implements OnInit {
  constructor(public service: CustomerService, private toastr: ToastrService) {}

  ngOnInit() {
    this.service.listTheCustomers();
  }
  populateForm(cust: Customer) {
    this.service.formData = Object.assign({}, cust);
  }
  onDelete(id: number) {
    if (confirm("are you sure you want to delete this record?")) {
      this.service
        .deleteCustomer(id)
        .subscribe(res => this.service.listTheCustomers());
      this.toastr.warning("Deleted successfully", "customer Deleted");
    }
  }
}
