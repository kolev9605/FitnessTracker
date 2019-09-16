import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { MyErrorStateMatcher } from 'src/app/helpers/errorStateMatcher';
import { AuthService } from 'src/app/services/auth.service';
import { RegisterModel } from 'src/app/models/auth/register.model';
import { SpinnerService } from 'src/app/services/spinner.service';
import { NotificationService } from 'src/app/services/notification.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css', '../auth.css']
})
export class RegisterComponent implements OnInit {
  registerForm: FormGroup;
  matcher = new MyErrorStateMatcher();

  constructor(
    private authService: AuthService, 
    private spinnerService: SpinnerService,
    private notificationService: NotificationService) { }

  ngOnInit() {
    this.registerForm = new FormGroup({
      'email': new FormControl(null, [Validators.email, Validators.required]),
      'passwords': new FormGroup({
        'password': new FormControl(null, [Validators.required, Validators.minLength(5)]),
        'confirmPassword': new FormControl(null, [Validators.required])
      }, this.passwordConfirming ),
      'firstName' : new FormControl(null, Validators.required),
      'lastName' : new FormControl(null, Validators.required) 
    });
  }

  onSubmit() {
    this.spinnerService.show();
    let registerModel: RegisterModel = {
      email: this.registerForm.get('email').value,
      password: this.registerForm.get('passwords.password').value,
      confirmPassword: this.registerForm.get('passwords.confirmPassword').value
    }

    this.authService.register(registerModel).subscribe(result => {
      this.spinnerService.hide();
      this.notificationService.showSuccess("yey");
    }, error => {
      this.spinnerService.hide();
      this.notificationService.showError(error);
    });
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