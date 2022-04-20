import { Component, OnInit } from '@angular/core';

import {Router} from '@angular/router';

@Component({
  selector: 'app-user-detail-component',
  templateUrl: './user-detail-component.component.html',
  styleUrls: ['./user-detail-component.component.css']
})
export class UserDetailComponentComponent implements OnInit {

  constructor(private router : Router) { }

  ngOnInit(): void {

    if(localStorage.getItem("user") == null)
    {
      this.router.navigate(['/']);
    }


  }

}
