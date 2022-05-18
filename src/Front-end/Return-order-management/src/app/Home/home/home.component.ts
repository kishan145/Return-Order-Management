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
  private stepper!: Stepper;
  constructor(
    private route: Router
    // private stepper: Stepper
    ) { }

  ngOnInit(): void {
    this.stepper = new Stepper(document.querySelector('#stepper1')!, {
      linear: false,
      animation: true
    })
    this.user = history.state.isLoggedIn
    console.log(history.state,'history')
  }

  next() {
    this.stepper.next();
  }
}
