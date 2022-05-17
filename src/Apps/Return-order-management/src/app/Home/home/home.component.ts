import { Component, OnInit } from '@angular/core';
import Stepper from 'bs-stepper';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  name = 'Project'
  private stepper!: Stepper;
  constructor(
    // private stepper: Stepper
    ) { }

  ngOnInit(): void {
    this.stepper = new Stepper(document.querySelector('#stepper1')!, {
      linear: false,
      animation: true
    })
  }

  next() {
    this.stepper.next();
  }
}
