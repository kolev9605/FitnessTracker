import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css', '../auth.css']
})
export class LoginComponent implements OnInit {
  loginForm: FormGroup;
  constructor() { }

  ngOnInit() {
    this.loginForm = new FormGroup({
      'email': new FormControl(null, [Validators.email, Validators.required]),
      'password': new FormControl(null,  [Validators.required, Validators.minLength(5)])
    });
  }

  onSubmit() {
    console.log(this.loginForm);
    this.loginForm.reset();
  }
}
