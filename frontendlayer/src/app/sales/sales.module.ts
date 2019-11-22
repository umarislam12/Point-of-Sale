import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { SaleComponent } from "./sale/sale.component";
import { SaleLineComponent } from "./sale-line/sale-line.component";
import { HttpClientModule } from "@angular/common/http";
//import { Observable } from "rxjs";
import {
  MatCardModule,
  MatTableModule,
  MatGridListModule,
  MatInputModule,
  MatAutocompleteModule,
  MatDatepickerModule,
  MatNativeDateModule,
  MatButtonModule,
  MatIconModule
} from "@angular/material";
import { SaleListComponent } from "./sale-line/sale-list/sale-list.component";
import { CustomerService } from "../shared/customer/customer.service";

import { ToastrModule } from "ngx-toastr";
import { ProductsService } from "../shared/products/products.service";
//import { ProductService } from "../shared/product/product.service";

@NgModule({
  declarations: [SaleComponent, SaleLineComponent, SaleListComponent],
  imports: [
    CommonModule,
    MatCardModule,
    MatTableModule,
    HttpClientModule,
    MatGridListModule,
    MatInputModule,
    MatAutocompleteModule,
    FormsModule,
    ReactiveFormsModule,
    MatDatepickerModule,
    MatNativeDateModule,
    MatButtonModule,
    MatIconModule,
    ToastrModule.forRoot()
  ],
  exports: [SaleComponent, SaleLineComponent, SaleListComponent],
  providers: [CustomerService, ProductsService]
})
export class SalesModule {}
