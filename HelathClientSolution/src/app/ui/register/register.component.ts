import { Component, OnInit } from '@angular/core';
import { Validators, FormControl, FormGroup } from '@angular/forms';
import { SignUpModel } from 'src/app/models/authModels/signupModel';
import { AuthService } from 'src/app/services/http-services/auth.service';
import { RegisterModule } from './register.module';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  constructor(private authservice: AuthService) { }
  ngOnInit(): void {
  }

  registerForm: FormGroup = new FormGroup({
    email: new FormControl(null, [Validators.required, Validators.email]),
    name: new FormControl(null, [Validators.required, Validators.min(2), Validators.max(50)]),
    surname: new FormControl(null, [Validators.required, Validators.min(2), Validators.max(50)]),
    password: new FormControl(null, [Validators.required, Validators.min(5)])
  });
  registerModel: SignUpModel;

  registerClick() {
    this.registerModel = this.registerForm.value as SignUpModel;
    console.table(this.registerModel);
    this.authservice.signUp(this.registerModel).subscribe(i => {
      console.log('slm');
    })
  }
}
