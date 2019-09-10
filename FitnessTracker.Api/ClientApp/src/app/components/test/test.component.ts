import { Component, OnInit } from '@angular/core';
import { TestItem } from 'src/app/models/test-item-model';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-test',
  templateUrl: './test.component.html',
  styleUrls: ['./test.component.css']
})
export class TestComponent implements OnInit {
  testItems: TestItem[] = [
      new TestItem(1, 'Hi'),
      new TestItem(2, 'Hi2')
  ]

  constructor(private http: HttpClient) { }

  ngOnInit() {
  }

  onEmmitedEvent(data: string) {
    console.log(data);
  }

  testHttp() {
    this.http.get('https://localhost:44363/api/values').subscribe(data => {
      console.log(data);
    },
    (error) => {
      console.log(error);
    })
  }
}
