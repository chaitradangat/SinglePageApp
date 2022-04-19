import { Component, OnInit,Input } from '@angular/core';

import { Session } from '../Session';


@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {

  @Input()
  session!: Session;
  
  constructor() { }

  ngOnInit(): void {
    this.session = new Session();

    this.session.setLoggedInUser("test","test");
  }
  logout(){
    this.session.logout();    
  }

}



