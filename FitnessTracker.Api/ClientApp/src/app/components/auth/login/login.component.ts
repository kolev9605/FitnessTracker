import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { AuthService } from 'src/app/services/auth.service';
import { LoginModel } from 'src/app/models/auth/login.model';
import { SpinnerService } from 'src/app/services/spinner.service';
import { NotificationService } from 'src/app/services/notification.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css', '../auth.css']
})
export class LoginComponent implements OnInit {
  loginForm: FormGroup;
  constructor(
    private authService: AuthService,
    private spinnerService: SpinnerService,
    private notificationService: NotificationService) { }

  ngOnInit() {
    this.loginForm = new FormGroup({
      'email': new FormControl(null, [Validators.email, Validators.required]),
      'password': new FormControl(null,  [Validators.required, Validators.minLength(5)])
    });
  }

  onSubmit() {    
    this.spinnerService.show();
    let loginModel: LoginModel = {
      email: this.loginForm.get('email').value,
      password: this.loginForm.get('password').value
    }

    this.authService.login(loginModel).subscribe(result => {
      this.spinnerService.hide();
      this.notificationService.showSuccess("yey");
    }, error => {
      this.spinnerService.hide();
      this.notificationService.showError(error);
    });
  }
}
