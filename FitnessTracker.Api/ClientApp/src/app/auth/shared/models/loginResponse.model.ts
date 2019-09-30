import { ResponseModel } from './response.model';

export class LoginResponseModel implements ResponseModel {
  email: string;
  token: string;
  userId: string;
  expirationDate: Date;
}