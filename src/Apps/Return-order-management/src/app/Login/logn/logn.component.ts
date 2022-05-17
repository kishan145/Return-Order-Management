import { Component, OnInit, TemplateRef, ViewChild } from '@angular/core';
import { AbstractControl, FormBuilder, FormGroup, ValidationErrors, Validators } from '@angular/forms';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
@Component({
  selector: 'app-logn',
  templateUrl: './logn.component.html',
  styleUrls: ['./logn.component.css']
})
export class LognComponent implements OnInit {
  @ViewChild('loginModal', {static:false}) popup:any;
  @ViewChild('signUpModal', {static:false}) popup2:any;
  public loginForm: FormGroup = new FormGroup({});
  public signupForm: FormGroup = new FormGroup({});

  displayStyle = 'none'
  displayStyle2 = 'none'
  public oldUser = true;

  constructor(private fb: FormBuilder) { }

  ngOnInit(): void {
    this.displayStyle = 'block'
    this.loginForm = this.fb.group({
      username: ['', Validators.required],
      password: ['', Validators.required]
  })
  }
  submitForm(){

  }
  submitNewForm() {

  }
  createAccount() {
    this.displayStyle = 'none';
    this.oldUser = false;
    this.displayStyle2 = 'block';
    this.signupForm = this.fb.group({
      username: ['',[Validators.pattern("^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$"), Validators.required]],
      password: ['', [Validators.required, this.patternValidator]],
      confirmPassword: ['',Validators.required]
      }, {validator: this.confirmPassword})
  }

  patternValidator(c: AbstractControl): ValidationErrors {
    if (!c.value) {
      return  {invalidPassword: true};
    }
    const regex = new RegExp('^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9]).{8,}$');
    const valid = regex.test(c.value);
    return valid ? {invalidPassword: false} : { invalidPassword: true };
  };

  confirmPassword(c:any): any{
    if(!c.controls.confirmPassword || !c.controls.password){
      return null;
    }
    if(c.controls.confirmPassword.errors && !c.controls.confirmPassword.errors.passwordMismatch ){
      return null;
    }
    if(c.controls.confirmPassword.value !== c.controls.password.value){
      c.controls.confirmPassword.setErrors({passwordMismatch: true})
    } else{
      c.controls.confirmPassword.setErrors(null);
    }
  }

  get f(){
    return this.signupForm.controls;
  }
}
