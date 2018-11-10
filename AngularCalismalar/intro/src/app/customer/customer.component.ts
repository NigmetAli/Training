import { Component, OnInit, Input } from '@angular/core';
import { Customer } from './customer';

@Component({
  selector: 'app-customer',
  templateUrl: './customer.component.html',
  styleUrls: ['./customer.component.css']
})
export class CustomerComponent implements OnInit {

  constructor() { }

  customers: Customer[] = []
  selectedCustomer: Customer;
  @Input() city: string; //biz city yi app.component te genel olarak tanımladık,html e bak

  ngOnInit() {
    this.customers = [
      { id: 1, firstName: "Niğmet Ali", lastName: "KOCA", age: 25 },
      { id: 2, firstName: "Mustafa", lastName: "KOCA", age: 64 },
      { id: 3, firstName: "Zahide", lastName: "KOCA", age: 62 }
    ]
  }


  selectCustomer(customer: Customer) {
    this.selectedCustomer = customer;
    //alert(customer.firstName)
  }
}