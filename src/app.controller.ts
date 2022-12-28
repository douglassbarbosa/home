import { Controller, Get } from '@nestjs/common';
import { PrismaService } from './database/prisma.service';

@Controller()
export class AppController {
  constructor(private prisma: PrismaService) {}

  @Get('cars')
  async getHello() {
    const cars = await this.prisma.carManufacturer.create({
      data: {
        id: 'sport',
        name: 'Camaro',
        manufacture: 'Ford',
      },
    });

    return { cars };
  }
}
