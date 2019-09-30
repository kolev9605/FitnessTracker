import { ResponseModel } from './response.model'

export class RegisterResponseModel implements ResponseModel {
  email: string;  
  token: string;
  userId: string;
  expirationDate: Date;
}