import { Customer } from "./customer.model";
import { Injectable } from "@angular/core";
import "rxjs/add/operator/map";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { map } from "rxjs-compat/operator/map";
@Injectable({
  providedIn: "root"
})
export class CustomerService {
  formData: Customer;
  custList: Customer[];
  readonly rootURL = "http://localhost:5000/api";
  constructor(private http: HttpClient) {}

  postCustomer(formData: Customer) {
    return this.http.post(
      this.rootURL + "/Customer",
      formData
      //  headers: new HttpHeaders({
      //   "Content-Type": "application/json"
      //  })
    );
  }
  listTheCustomers() {
    this.http
      .get(this.rootURL + "/Customer")
      .toPromise()
      .then(res => (this.custList = res as Customer[]));
  }
  getCustomers() {
    return this.http.get(this.rootURL + "/Customer").map(res => res);
  }
  putCustomer(formData: Customer) {
    return this.http.put(this.rootURL + "/Customer/" + formData.id, formData);
  }
  deleteCustomer(id: number) {
    return this.http.delete(this.rootURL + "/Customer/" + id);
  }
}
