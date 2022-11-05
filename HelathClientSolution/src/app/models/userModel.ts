export class UserModel {
  constructor(public email: string, public accesstoken: string, public tokenExpritaion: Date, public refreshToken: string) {
  }
  get token() {
    if (!this.tokenExpritaion || new Date() > this.tokenExpritaion)
      return null;
    else
      return this.accesstoken;
  }
}
