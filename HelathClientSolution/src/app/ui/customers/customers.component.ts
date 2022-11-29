import { Component, OnInit } from '@angular/core';
import { CustomerModel } from 'src/app/models/authModels/customerModel';
import { CustomerService } from 'src/app/services/http-services/customer.service';

@Component({
  selector: 'app-customers',
  templateUrl: './customers.component.html',
  styleUrls: ['./customers.component.css']
})
export class CustomersComponent implements OnInit {
  customerList: CustomerModel[];
  constructor(private customerService: CustomerService) {
    this.customerService.get().then(i =>{
      this.customerList =i.data;
      console.table(this.customerList);
    });

  }
  ngOnInit(): void {

  }

}
