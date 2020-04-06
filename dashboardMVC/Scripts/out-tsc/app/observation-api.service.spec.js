import { TestBed } from '@angular/core/testing';
import { ObservationAPIService } from './observation-api.service';
describe('ObservationAPIService', () => {
    let service;
    beforeEach(() => {
        TestBed.configureTestingModule({});
        service = TestBed.inject(ObservationAPIService);
    });
    it('should be created', () => {
        expect(service).toBeTruthy();
    });
});
//# sourceMappingURL=observation-api.service.spec.js.map