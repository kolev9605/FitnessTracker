import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { MyErrorStateMatcher } from 'src/app/helpers/errorStateMatcher';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css', '../auth.css']
})
export class RegisterComponent implements OnInit {
  registerForm: FormGroup;
  matcher = new MyErrorStateMatcher();

  constructor() { }

  ngOnInit() {
    this.registerForm = new FormGroup({
      'email': new FormControl(null, [Validators.email, Validators.required]),
      'passwords': new FormGroup({
        'password': new FormControl(null, [Validators.required, Validators.minLength(5)]),
        'confirmPassword': new FormControl(null, [Validators.required])
      }, this.passwordConfirming ),      
    });

    this.registerForm.statusChanges.subscribe(() => {
      console.log(this.registerForm);
    })
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
    let errorMessage = null;
    if (this.registerForm.get('passwords.confirmPassword').hasError('required')){
      errorMessage = "Confirm password is required";
    } else if (this.registerForm.get('passwords').hasError('confirmPasswordDoesNotMatch')) {
      errorMessage = "Confirm password does not match";
    }

    return errorMessage;
  }
}