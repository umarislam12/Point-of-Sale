import { SignupFormComponent } from "./signup/signup-form.component";
import { BrowserModule } from "@angular/platform-browser";
import { NgModule } from "@angular/core";
import { HttpClientModule } from "@angular/common/http";
import { CommonModule } from "@angular/common";
import { BrowserAnimationsModule } from "@angular/platform-browser/animations";
//import {NgxPaginationModule} from 'ngx-pagination'; // <-- import the module

import { ToastrModule } from "ngx-toastr";

import { AppComponent } from "./app.component";
import { ReactiveFormsModule } from "@angular/forms";
import { CustomersComponent } from "./customers/customers.component";
import { CustomerComponent } from "./customers/customer/customer.component";
import { CustomerListComponent } from "./customers/customer-list/customer-list.component";
import { CustomerService } from "./shared/customer/customer.service";
import { FormsModule } from "@angular/forms";
import {
  MatButtonModule,
  MatIconModule,
  MatMenuModule,
  MatPaginatorModule
} from "@angular/material";
import { AppRoutingModule } from "./app-routing.module";
import { SalesModule } from "./sales/sales.module";
// import { SaleComponent } from "./sales/sale/sale.component";
@NgModule({
  declarations: [
    AppComponent,
    //NgxPaginationModule,
    CustomersComponent,
    CustomerComponent,
    CustomerListComponent,
    SignupFormComponent
    // SaleComponent
  ],
  imports: [
    BrowserModule,
    SalesModule,
    FormsModule,
    HttpClientModule,
    CommonModule,
    BrowserAnimationsModule,
    MatButtonModule,
    MatIconModule,
    MatMenuModule,
    ReactiveFormsModule,
    MatPaginatorModule,
    // required animations module
    ToastrModule.forRoot(),
    AppRoutingModule
  ],
  providers: [CustomerService],
  bootstrap: [AppComponent]
})
export class AppModule {}
