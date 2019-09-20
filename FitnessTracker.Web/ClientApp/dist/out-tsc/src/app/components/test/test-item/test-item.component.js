import * as tslib_1 from "tslib";
import { Component, Input, EventEmitter, Output } from '@angular/core';
let TestItemComponent = class TestItemComponent {
    constructor() {
        this.emmited = new EventEmitter();
    }
    ngOnInit() {
    }
    sayHello() {
        this.emmited.emit(this.testItemModel.text);
    }
};
tslib_1.__decorate([
    Output()
], TestItemComponent.prototype, "emmited", void 0);
tslib_1.__decorate([
    Input()
], TestItemComponent.prototype, "testItemModel", void 0);
TestItemComponent = tslib_1.__decorate([
    Component({
        selector: 'app-test-item',
        templateUrl: './test-item.component.html',
        styleUrls: ['./test-item.component.css']
    })
], TestItemComponent);
export { TestItemComponent };
//# sourceMappingURL=test-item.component.js.map