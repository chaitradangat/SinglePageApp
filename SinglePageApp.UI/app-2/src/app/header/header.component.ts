import { Component, OnInit,Input } from '@angular/core';

import { Session } from '../Session';

import { Router } from '@angular/router';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {

  @Input()
  session!: Session;


  @Input()
  public isUserLoggedIn:boolean;
  
  constructor(private router : Router) { 

    this.isUserLoggedIn = false;
  }

  ngOnInit(): void {

    this.isUserLoggedIn = localStorage.getItem("user") != null;
  }
  logout(){
    localStorage.clear();    

    this.router.navigate(['/']);
  }

}



