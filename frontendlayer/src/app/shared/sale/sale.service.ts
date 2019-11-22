import { Injectable } from "@angular/core";
import { Sale } from "./sale.model";
import { HttpClient } from "@angular/common/http";

@Injectable({
  providedIn: "root"
})
export class SaleService {
  formData: Sale;
  salelineList: Sale[];
  readonly rootURL = "http://localhost:5000/api";
  constructor(private http: HttpClient) {}
  postsaleline(formData: Sale) {
    console.log("servicre products", formData);
    debugger;
    return this.http.post(
      this.rootURL + "/SaleLine",
      formData
      //, {
      // headers: new HttpHeaders({
      //   "Content-Type": "application/json"
      // })
      //});
    );
  }

  //RXJS
  // getProducts(): Observable<Products[]> {
  //   return this.http.get<Products[]>(this.rootURL + "/SaleLine");
  // }

  getProducts() {
    return this.http.get(this.rootURL + "/sales").map(res => res);
  }
  getObject() {
    return this.http.get(this.rootURL + "/SaleLine");
    // .toPromise()
    // .then(res => (this.prodList = res as Products[]));
  }
  listsalelines() {
    this.http
      .get(this.rootURL + "/SaleLine")
      .toPromise()
      .then(res => (this.salelineList = res as Sale[]));
  }
  putProducts(formData: Sale) {
    return this.http.put(
      this.rootURL + "/SaleLine/" + formData.saleId,
      formData
    );
  }
  deleteSaleLine(saleId: number) {
    return this.http.delete(this.rootURL + "/SaleLine/" + saleId);
  }
  getData() {
    return this.http.get(this.rootURL + "/SaleLine").map(res => res);
  }
}
