import { NgModule } from "@angular/core";

import { RouterModule, Routes } from "@angular/router";

import { SaleComponent } from "./sales/sale/sale.component";
import { CustomersComponent } from "./customers/customers.component";
const appRoutes: Routes = [
  {
    path: "customer",
    component: CustomersComponent
  },
  {
    path: "sale",
    component: SaleComponent
  },
  {
    path: "",
    redirectTo: "AppComponent",
    pathMatch: "full"
  }
];
@NgModule({
  imports: [RouterModule.forRoot(appRoutes)],
  exports: [RouterModule]
})
export class AppRoutingModule {}
// export const routingComponents = [CustomerComponent, SaleComponent];
