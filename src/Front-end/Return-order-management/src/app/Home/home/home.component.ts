import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import Stepper from 'bs-stepper';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  public user = false;
  public step1 = false;
  public step1Form: FormGroup = new FormGroup({});
  public step2Form: FormGroup = new FormGroup({});
  name = 'Project'
  constructor(
    private route: Router,
    private fb: FormBuilder
    ) { }

  ngOnInit(): void {
    
    this.user = history.state.isLoggedIn
    if (this.user){
      this.step1 = true;
      this.step1Form = this.fb.group({
        name: ['', Validators.required],
        number: ['', Validators.required],
        Componentname: ['', Validators.required],
        quantity: ['', Validators.required],
        description: ['', Validators.required],

    })
    }
  }
  proceedToNext(){
    this.step1 = false;

  }
  save(){

  }

  close(){
    
  }
  
}
