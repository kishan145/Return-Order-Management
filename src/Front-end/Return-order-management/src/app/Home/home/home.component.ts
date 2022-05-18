import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import Stepper from 'bs-stepper';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  public user = false;
  name = 'Project'
  constructor(
    private route: Router
    // private stepper: Stepper
    ) { }

  ngOnInit(): void {
    
    this.user = history.state.isLoggedIn

  }

  
}
