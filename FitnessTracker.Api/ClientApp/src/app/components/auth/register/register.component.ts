import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators, AbstractControl } from '@angular/forms';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  registerForm: FormGroup;
  constructor() { }

  ngOnInit() {
    this.registerForm = new FormGroup({
      'email': new FormControl(null, [Validators.email, Validators.required]),
      'passwords': new FormGroup({
        'password': new FormControl(null, Validators.required),
        'confirmPassword': new FormControl(null, [Validators.required])
      }, this.passwordConfirming ),
      
    });
  }

  onSubmit() {
    console.log(this.registerForm);
  }

  passwordConfirming(c: FormControl): { [k: string]: boolean } {
    let password = c.get('password').value;
    let confirmPassword = c.get('confirmPassword').value;

    if (password !== confirmPassword) {
      return {'confirmPasswordDoesNotMatch': true};
    }

    return null;
  }

  getConfirmPasswordErrorMessage() {
    let passwordsControl: AbstractControl = this.registerForm.get('passwords');
    
    if(!passwordsControl.valid) {
      let errorMessage = null;
      if (this.registerForm.get('passwords.confirmPassword').hasError('required')){
        errorMessage = "Confirm password is required";
      } else if (passwordsControl.hasError('confirmPasswordDoesNotMatch')) {
        console.log("not match")
        errorMessage = "Confirm password does not match";
      } else {
        errorMessage = "Password is invalid";
      }

      return errorMessage;
    }

    return null;
  }
} 