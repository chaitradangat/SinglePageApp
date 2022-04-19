import { Component, OnInit } from '@angular/core';

import { FormsModule, ReactiveFormsModule, FormControl, Validators } from '@angular/forms';


interface Gender
{
 value: string;
 viewValue : string;
}

@Component({
  selector: 'app-registration-component',
  templateUrl: './registration-component.component.html',
  styleUrls: ['./registration-component.component.css']
})
export class RegistrationComponentComponent implements OnInit {


 public genders: Gender[] = [
    {value: 'male-0', viewValue: 'Male'},
    {value: 'female-1', viewValue: 'Female'},
    {value: 'other-2', viewValue: 'Other'},
  ];

  constructor() { }

  ngOnInit(): void {
  }

  selectFormControl = new FormControl('', Validators.required);

  register()
{

  return false;
}


}
