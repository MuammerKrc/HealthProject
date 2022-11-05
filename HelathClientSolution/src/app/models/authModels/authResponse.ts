export interface AuthResponse {
  accessToken: string;
  refresToken: string;
  expirationAccessToken: Date;
  expirationRefreshToken: Date;
}
