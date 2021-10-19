# Introduction to Linux

## Linux Terminology 
- Kernel: Glue between hardware and applications

- distribution: Debian, SUSE, Fedora, etc. 

- boot loader: boots the operating system, ex: GRUB and ISOLINUX.

- service: Program that runs as a background process, ex: httpd, nfsd, ntpd, ftpd and named.

- filesystem: Method for storing and organizing files, ex: ext3, ext4, FAT, XFS NTFS and Btrfs.

- X Window system: Graphical subsystem on nearly all Linux systems

- desktop environment: Graphical user interface on top of the operating system, ex: GNOME, KDE, Xfce, and Fluxbox.

- commnad line: Interface for typing commands on top of the operating system.

- Shell: Command line interpreter that interprets the command line input and instructs the operating system to perform any necessary tasks and commands, ex: bash, tcsh and zsh.

## BIOS - The first Step
Basic Input/Output System (BIOS) initializes the hardware, including the screen and keyboard, and tests the main memory. This process is also called POST (Power On Self Tesr). The BIOS software is stored on a ROM chip on the motherboard. After this, the remainder of the boot process is controlled by the operating system (OS).

Once the POST is completed, the system contol passes from the BIOS to the boot loader. The boot loader is usually stored on one of the hard disks in the system, either in the boot sector )for traditional BIOS/MBR systems) or the EFI partition (for more recent (Unified) Extensible Firmware Interface or EFI/UEFI systems).

The boot loader is responsible for loading the kernel image and the initial RAM disk or filesystem.

- Boot Loader in Action

The boot loader has tow distinct stages: 

For systems using the BIOS/MBR method, the boot loader resides at the first sector of the hard disk, also known as the Master Boot Record (MBR). The size of the MBR is just 512 bytes. In this stage, the boot loader examines the partition table and finds a bootable partition. Once it finds a bootable partition, it then searches for the second stage boot loader, for example, GRUB, and loads it into RAM (Random Access Memory). For systems using the EFI/UEFI method, UEFI firmware reads its Boot Manager data to determine which UEFI application is to be launched and from where. The firmware then launches the UEFI application, for example GRUB, as defined in the boot entry in the firmware's boot manager. 

The second stage boot loader resides under /boot. A splash screen is displayed, which allows us to choose which operating system (OS) to boot. After choosing the OS, the boot loader loads the kernel of the selected operating system into RAM and passes control to it. Kernels are almost always compressed, so its first job is to uncompress itself. After this, it will check and analyze the system hardware and initialize any hardware device drivers built into the kernel. 
