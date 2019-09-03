import { Component, OnInit } from '@angular/core';
import { TestItem } from 'src/app/models/test-item-model';

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

  constructor() { }

  ngOnInit() {
  }

  onEmmitedEvent(data: string) {
    console.log(data);
  }
}
